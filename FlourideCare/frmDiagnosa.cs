using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlourideCare
{
    public partial class frmDiagnosa : Form
    {
        FluorideDBDataContext db = new FluorideDBDataContext();
        validasi va;
        tbl_Diagnosa diag;
        frmUtama frm;
        String primary;
        int klik = 0;
        public frmDiagnosa()
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
        }
        public frmDiagnosa(frmUtama frm)
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
            this.frm = frm;
        }

        public void loadGrid()
        {
            dgvDiagnosa.DataSource = (from d in db.tbl_Diagnosas
                                     join a in db.tbl_Antrians
                                     on d.id equals a.id

                                     join us in db.tbl_Users
                                     on a.id_user equals us.id_user

                                     join r in db.tbl_Ruangans
                                     on a.id_ruangan equals r.id_ruangan

                                     join dok in db.tbl_Dokters
                                     on r.id_dokter equals dok.id_dokter
                                     select new
                                     {
                                         IDDiagnosa = d.id_diagnosa,
                                         IDRuangan = a.id_ruangan,
                                         NoAntrian = a.no_antrian,
                                         Pasien = us.nama,
                                         Dokter = dok.nama,
                                         HasilDiagnosa = d.hasil_diagnosa,
                                         Status = d.status,
                                         Tanggal = a.tanggal
                                     }).ToList();

            if(db.tbl_Diagnosas.Count() > 0)
            {
                var setPrimary = from d in 
                                    ( from d in db.tbl_Diagnosas
                                      select new
                                      {
                                        Column1 = (int?)Convert.ToInt32(d.id_diagnosa.Substring(2 + 5 - 1, (int)d.id_diagnosa.Length - 1)),
                                        Dummy = "x"
                                      })
                                  group d by new { d.Dummy } into g
                                  select new
                                  {
                                      kode = (int?)g.Max(p => p.Column1 + 1)
                                  };
                foreach(var v in setPrimary)
                {
                    primary = "DIAG - " + v.kode.ToString();
                }
            }

            else
            {
                primary = "DIAG - " + 1;
            }

            tbIddiagnosa.Text = primary;

            cmbIdantrian.DataSource = from an in db.tbl_Antrians
                                      where an.tanggal >= DateTime.Now
                                      select new
                                      {
                                          id = an.id,
                                          ruangan = an.id_ruangan + " " + an.no_antrian
                                      };
            cmbIdantrian.DisplayMember = "ruangan";
            cmbIdantrian.ValueMember = "id";

        }

        private void frmDiagnosa_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void setTextBox()
        {
            if(!String.IsNullOrEmpty(tbIddiagnosa.Text))
            {
                diag = db.tbl_Diagnosas.FirstOrDefault(x => x.id_diagnosa == tbIddiagnosa.Text);
                if(diag != null)
                {
                    tbIddiagnosa.Text = diag.id_diagnosa;
                    cmbIdantrian.Text = diag.id.ToString();
                    rtbHasil.Text = diag.hasil_diagnosa;
                    rtbResep.Text = diag.resep;
                    btnTambah.Text = "UBAH";
                }

                else
                {
                    va.clear("tbIddiagnosa");
                    btnTambah.Text = "TAMBAH";
                }
            }
        }

        private void aksi(String aksinya)
        {
            diag = aksinya == "insert" ? new tbl_Diagnosa() : db.tbl_Diagnosas.FirstOrDefault(x => x.id_diagnosa == tbIddiagnosa.Text);
            diag.id = int.Parse(cmbIdantrian.SelectedValue.ToString());
            diag.hasil_diagnosa = rtbHasil.Text;
            diag.resep = rtbResep.Text;
            diag.status = "BELUM DIBAYAR";
            if(aksinya == "insert")
            {
                diag.id_diagnosa = tbIddiagnosa.Text;
                db.tbl_Diagnosas.InsertOnSubmit(diag);
            }

            db.SubmitChanges();

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                String pesan = "";
                if (va.doValidation() == false) return;
                diag = db.tbl_Diagnosas.FirstOrDefault(x => x.id_diagnosa == tbIddiagnosa.Text);
                if (diag == null)
                {
                    aksi("insert");
                    pesan = "menambah";
                }

                else
                {
                    aksi("update");
                    pesan = "memperbaharui";
                }

                MessageBox.Show("Berhasil " + pesan + " data", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadGrid();
            }

            catch (Exception err)
            {
                MessageBox.Show("Terjadi Kesalahan" + err.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRuangan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
        }

        private void dgvRuangan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
            if(klik == 1)
            {
                foreach(DataGridViewRow rw in this.dgvDiagnosa.SelectedRows)
                {
                    tbIddiagnosa.Text = rw.Cells[0].Value.ToString();
                }
                setTextBox();
            }

            else
            {
                MessageBox.Show("Silahkan pilih baris yang ingin di ubah!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadGrid();
            va.clear("tbIddiagnosa");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(klik == 1)
            {
                foreach(DataGridViewRow rw in this.dgvDiagnosa.SelectedRows)
                {
                    primary = rw.Cells[0].Value.ToString();
                }

                diag = db.tbl_Diagnosas.Where(x => x.id_diagnosa == primary).Single();
                db.tbl_Diagnosas.DeleteOnSubmit(diag);
                db.SubmitChanges();
                loadGrid();
            }

            else
            {
                MessageBox.Show("Silahkan pilih baris yang ingin di hapus!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

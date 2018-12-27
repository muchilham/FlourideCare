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
    public partial class frmRuangan : Form
    {
        FluorideDBDataContext db = new FluorideDBDataContext();
        frmUtama frm;
        validasi va;
        tbl_Ruangan ru;
        String primary;
        int klik = 0;
        public frmRuangan()
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
        }
        public frmRuangan(frmUtama frm)
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
            this.frm = frm;
        }

        private void loadGrid()
        {
            if (db.tbl_Ruangans.Count() > 0)
            {
                var setPrimary = from r in
                                     (from r in db.tbl_Ruangans
                                      select new
                                      {
                                          Column1 = (int?)Convert.ToInt32(r.id_ruangan.Substring(2 + 6 - 1, (int)r.id_ruangan.Length - 1)),
                                          Dummy = "x"
                                      })
                                 group r by new { r.Dummy } into g
                                 select new
                                 {
                                     kode = (int?)g.Max(p => p.Column1 + 1)
                                 };
                foreach(var b in setPrimary)
                {
                    primary = "RUANG - " + b.kode.ToString();
                }
            }

            else
            {
                primary = "RUANG - " + 1;
            }
            dgvRuangan.DataSource = (from b in db.tbl_Ruangans
                                    join t in db.tbl_tipes
                                    on b.id_tipe equals t.id_tipe

                                    join d in db.tbl_Dokters
                                    on b.id_dokter equals d.id_dokter

                                    join j in db.tbl_Jadwals
                                    on b.id_jadwal equals j.id_jadwal

                                    select new
                                    {
                                        IDRuang = b.id_ruangan,
                                        NamaDokter = d.nama,
                                        Jenis = t.nama,
                                        Buka = j.mulai,
                                        Tutup = j.selesai
                                    }).ToList();
            tbIdruangan.Text = primary;

            cmbIdtipe.DataSource = from t in db.tbl_tipes
                                     select t;
            cmbIdtipe.DisplayMember = "nama";
            cmbIdtipe.ValueMember = "id_tipe";

            cmbIddokter.DataSource = from d in db.tbl_Dokters
                                     select d;
            cmbIddokter.DisplayMember = "nama";
            cmbIddokter.ValueMember = "id_dokter";

            cmbIdjadwal.DataSource = from j in db.tbl_Jadwals
                                     select j.id_jadwal;
        }

        private void setTextbox()
        {
            if(!String.IsNullOrEmpty(tbIdruangan.Text))
            {
                ru = db.tbl_Ruangans.FirstOrDefault(x => x.id_ruangan == tbIdruangan.Text);
                if(ru != null)
                {
                    tbIdruangan.Text = ru.id_ruangan;
                    tbNamaruangan.Text = ru.nama_ruangan;
                    cmbIdtipe.Text = ru.id_tipe;
                    cmbIddokter.Text = ru.id_dokter.ToString();
                    cmbIdjadwal.Text = ru.id_jadwal;
                    cmbStatus.Text = ru.status;
                    btnTambah.Text = "UBAH";
                }

                else
                {
                    va.clear("tbIdruangan");
                    btnTambah.Text = "TAMBAH";
                }
            }
        }

        private void aksi(String aksinya)
        {
            ru = aksinya == "insert" ? new tbl_Ruangan() : db.tbl_Ruangans.FirstOrDefault(x => x.id_ruangan == tbIdruangan.Text);
            ru.nama_ruangan = tbNamaruangan.Text;
            ru.id_tipe = cmbIdtipe.SelectedValue.ToString();
            ru.id_dokter = int.Parse(cmbIddokter.SelectedValue.ToString());
            ru.id_jadwal = cmbIdjadwal.SelectedValue.ToString();
            ru.status = cmbStatus.Text;
            if(aksinya == "insert")
            {
                ru.id_ruangan = tbIdruangan.Text;
                db.tbl_Ruangans.InsertOnSubmit(ru);
            }

            db.SubmitChanges();
        }

        private void frmRuangan_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void dgvRuangan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                String pesan = "";
                if (va.doValidation() == false) return;
                ru = db.tbl_Ruangans.FirstOrDefault(x => x.id_ruangan == tbIdruangan.Text);
                if (ru == null)
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

        private void dgvRuangan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
            if(klik == 1)
            {
                foreach(DataGridViewRow rw in this.dgvRuangan.SelectedRows)
                {
                    tbIdruangan.Text = rw.Cells[0].Value.ToString();
                }
                setTextbox();
            }

            else
            {
                MessageBox.Show("Silahkan pilih baris yang ingin diperbaharui", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(klik == 1)
            {
                foreach(DataGridViewRow rw in this.dgvRuangan.SelectedRows)
                {
                    primary = rw.Cells[0].Value.ToString();
                }

                ru = db.tbl_Ruangans.Where(x => x.id_ruangan == primary).Single();
                db.tbl_Ruangans.DeleteOnSubmit(ru);
                db.SubmitChanges();
                loadGrid();
            }

            else
            {
                MessageBox.Show("Silahkan pilih baris yang ingin dihapus", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadGrid();
            va.clear("tbIdruangan");
        }


    }
}

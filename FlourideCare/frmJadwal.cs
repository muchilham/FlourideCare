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
    public partial class frmJadwal : Form
    {
        FluorideDBDataContext db = new FluorideDBDataContext();
        frmUtama frm;
        validasi va;
        tbl_Jadwal jad;
        String primary;
        int klik = 0;
        public frmJadwal()
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
        }
        public frmJadwal(frmUtama frm)
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
            this.frm = frm;
        }

        private void loadGrid()
        {
            if(db.tbl_Jadwals.Count() > 0)
            {
                var setprimary = from jad in
                                (from jad in db.tbl_Jadwals
                                        select new 
                                        {
                                            Column1 = (int?)Convert.ToInt32(jad.id_jadwal.Substring(2+4-1, (int)jad.id_jadwal.Length - 1)),
                                            Dummy = "x"
                                        })
                                group jad by new { jad.Dummy } into g
                                select new
                                {
                                    kode = (int?)g.Max(p => p.Column1 + 1)
                                };
                foreach(var b in setprimary)
                {
                    primary = "JAD - " + b.kode.ToString();
                }
            }

            else
            {
                primary = "JAD - " + 1;
            }
            tbIdjadwal.Text = primary;
            dgvJadwal.DataSource = db.tbl_Jadwals.ToList();
        }

        private void setTextbox()
        {
            if(!String.IsNullOrEmpty(tbIdjadwal.Text))
            {
                jad = db.tbl_Jadwals.FirstOrDefault(x => x.id_jadwal == tbIdjadwal.Text);
                if(jad != null)
                {
                    tbIdjadwal.Text = jad.id_jadwal;
                    dateTimePicker1.Value = DateTime.Parse(jad.mulai.ToString());
                    dateTimePicker2.Value = DateTime.Parse(jad.selesai.ToString());
                    btnTambah.Text = "UBAH";
                }

                else
                {
                    tbIdjadwal.Text = primary;
                    btnTambah.Text = "TAMBAH";
                }
            }
        }

        private void aksi(String aksinya)
        {
            jad = aksinya == "insert" ? new tbl_Jadwal() : db.tbl_Jadwals.FirstOrDefault(i => i.id_jadwal == tbIdjadwal.Text);
            jad.mulai = TimeSpan.Parse(dateTimePicker1.Text);
            jad.selesai = TimeSpan.Parse(dateTimePicker2.Text);
            if(aksinya == "insert")
            {
                jad.id_jadwal = tbIdjadwal.Text;
                db.tbl_Jadwals.InsertOnSubmit(jad);
            }

            db.SubmitChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadGrid();
            va.clear("tbIdjadwal");
        }

        private void dgvJadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
        }

        private void dgvJadwal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
            if(klik == 1)
            {
                foreach (DataGridViewRow rw in this.dgvJadwal.SelectedRows)
                {
                    tbIdjadwal.Text = rw.Cells[0].Value.ToString();
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
                foreach(DataGridViewRow rw in this.dgvJadwal.SelectedRows)
                {
                    primary = rw.Cells[0].Value.ToString();
                }

                jad = db.tbl_Jadwals.Where(x => x.id_jadwal == tbIdjadwal.Text).Single();
                db.tbl_Jadwals.DeleteOnSubmit(jad);
                db.SubmitChanges();
                loadGrid();
            }
        }

        private void frmJadwal_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                String pesan = "";
                if (va.doValidation() == false) return;
                jad = db.tbl_Jadwals.FirstOrDefault(x => x.id_jadwal == tbIdjadwal.Text);
                if(jad == null)
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


    }
}

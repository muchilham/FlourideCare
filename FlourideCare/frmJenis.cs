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
    public partial class frmJenis : Form
    {
        FluorideDBDataContext db = new FluorideDBDataContext();
        frmUtama frm;
        validasi va;
        tbl_tipe tip;
        String primary;
        int klik = 0;
        public frmJenis()
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
        }
        public frmJenis(frmUtama frm)
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
            this.frm = frm;
        }

        private void loadGrid()
        {
            if(db.tbl_tipes.Count() > 0 )
            {
                var setPrimary = from tip in
                                     (from tip in db.tbl_tipes
                                      select new
                                      {
                                          Column1 = (int?)Convert.ToInt32(tip.id_tipe.Substring(2 + 4 - 1, (int)tip.id_tipe.Length - 1)),
                                          Dummy = "x"
                                      })
                                 group tip by new { tip.Dummy } into g
                                 select new
                                 {
                                     kode = (int?)g.Max(p => p.Column1 + 1)
                                 };
                foreach(var b in setPrimary)
                {
                    primary = "TIP - " + b.kode.ToString();
                }
            }

            else
            {
                primary = "TIP - " + 1;
            }

            dgvJenis.DataSource = db.tbl_tipes.ToList();
            tbIdjenis.Text = primary;
        }

        private void setTextbox()
        {
            if(!String.IsNullOrEmpty(tbIdjenis.Text))
            {
                tip = db.tbl_tipes.FirstOrDefault(x => x.id_tipe == tbIdjenis.Text);
                if(tip != null)
                {
                    tbIdjenis.Text = tip.id_tipe;
                    tbNama.Text = tip.nama;
                    btnTambah.Text = "UBAH";
                }

                else
                {
                    va.clear("tbIdjenis");
                    btnTambah.Text = "TAMBAH";
                }
            }
        }

        private void aksi(String aksinya)
        {
            tip = aksinya == "insert" ? new tbl_tipe() : db.tbl_tipes.FirstOrDefault(x => x.id_tipe == tbIdjenis.Text);
            tip.nama = tbNama.Text;
            if(aksinya == "insert")
            {
                tip.id_tipe = tbIdjenis.Text;
                db.tbl_tipes.InsertOnSubmit(tip);
            }

            db.SubmitChanges();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                String pesan = "";
                if (va.doValidation() == false) return;
                tip = db.tbl_tipes.FirstOrDefault(x => x.id_tipe == tbIdjenis.Text);
                if (tip == null)
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

        private void dgvJenis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadGrid();
            va.clear("tbIdjenis");
        }

        private void dgvJenis_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
            if(klik == 1)
            {
                foreach(DataGridViewRow rw in this.dgvJenis.SelectedRows)
                {
                    tbIdjenis.Text = rw.Cells[0].Value.ToString();
                }
                setTextbox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (klik == 1)
            {
                foreach (DataGridViewRow rw in this.dgvJenis.SelectedRows)
                {
                    primary = rw.Cells[0].Value.ToString();
                }
                tip = db.tbl_tipes.Where(x => x.id_tipe == primary).Single();
                db.tbl_tipes.DeleteOnSubmit(tip);
                db.SubmitChanges();
                loadGrid();
            }

            else
            {
                MessageBox.Show("Silahkan pilih baris yang ingin dihapus", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmJenis_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

    }
}

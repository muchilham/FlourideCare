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
    public partial class frmObat : Form
    {
        FluorideDBDataContext db = new FluorideDBDataContext();
        frmUtama frm;
        tbl_Obat ob;
        validasi va;
        String primary;
        int klik = 0;
        public frmObat()
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
        }
        public frmObat(frmUtama frm)
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
            this.frm = frm;
        }

        private void loadGrid()
        {
            dgvObat.DataSource = (from o in db.tbl_Obats
                                  select new
                                  {
                                      IDObat = o.id_obat,
                                      Nama = o.nama_obat,
                                      Harga = o.harga,
                                      Stok = o.stok
                                  }).ToList();
        }

        private void setTextBox()
        {
            if(!String.IsNullOrEmpty(tbIdobat.Text))
            {
                ob = db.tbl_Obats.FirstOrDefault(x => x.id_obat == int.Parse(tbIdobat.Text));
                if(ob != null)
                {
                    tbIdobat.Text = ob.id_obat.ToString();
                    tbNama.Text = ob.nama_obat;
                    tbHarga.Text = ob.harga.ToString();
                    nudStok.Value = ob.stok;
                }

                else
                {
                    va.clear("tbIdobat");
                }
            }
        }

        private void aksi(String aksinya)
        {
            ob = aksinya == "insert" ? new tbl_Obat() : db.tbl_Obats.FirstOrDefault(x => x.id_obat == int.Parse(tbIdobat.Text));
            ob.nama_obat = tbNama.Text;
            ob.harga = float.Parse(tbHarga.Text);
            ob.stok = (int)nudStok.Value;
            if(aksinya == "insert")
            {
                ob.id_obat = int.Parse(tbIdobat.Text);
                db.tbl_Obats.InsertOnSubmit(ob);
            }

            db.SubmitChanges();
        }

        private void dgvObat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
        }

        private void dgvObat_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
            if(klik == 1)
            {
                foreach(DataGridViewRow rw in this.dgvObat.SelectedRows)
                {
                    tbIdobat.Text = rw.Cells[0].Value.ToString();
                }
                setTextBox();
            }

            else
            {
                MessageBox.Show("Silahkan pilih baris yang ingin diubah!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                String pesan = "";
                if (va.doValidation() == false) return;
                ob = db.tbl_Obats.FirstOrDefault(x => x.id_obat == int.Parse(tbIdobat.Text));
                if(ob == null)
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
                va.clear("");
            }
            catch (Exception err)
            {
                MessageBox.Show("Terjadi kesalahan", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(klik == 1)
            {
                foreach(DataGridViewRow rw in this.dgvObat.SelectedRows)
                {
                    primary = rw.Cells[0].Value.ToString();
                }
                ob = db.tbl_Obats.Where(x => x.id_obat == int.Parse(primary)).Single();
                db.tbl_Obats.DeleteOnSubmit(ob);
                db.SubmitChanges();
                loadGrid();
            }

            else
            {
                MessageBox.Show("Silahkan pilih baris yang ingin dihapus", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbIdobat_TextChanged(object sender, EventArgs e)
        {
            setTextBox();
        }

        private void tbIdobat_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }

        private void tbHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }

        private void frmObat_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
    }
}

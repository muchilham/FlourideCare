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
    public partial class frmDokter : Form
    {
        FluorideDBDataContext db = new FluorideDBDataContext();
        frmUtama frm;
        validasi va;
        tbl_Dokter dok;
        String primary;
        int klik = 0;
        public frmDokter()
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
        }

        public frmDokter(frmUtama frm)
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
            this.frm = frm;
        }

        private void loadGrid()
        {
            dgvDokter.DataSource = db.tbl_Dokters.ToList();
        }

        private void setTextbox()
        {
            if(!String.IsNullOrEmpty(tbIdDokter.Text))
            {
                dok = db.tbl_Dokters.FirstOrDefault(x => x.id_dokter == int.Parse(tbIdDokter.Text));
                if(dok != null)
                {
                    tbIdDokter.Text = dok.id_dokter.ToString();
                    tbNama.Text = dok.nama;
                    cmbJeniskelamin.Text = dok.jenis_kelamin;
                    dtpTanggallahir.Value = dok.tanggal_lahir;
                    rtbAlamat.Text = dok.alamat;
                    tbKota.Text = dok.kota;
                    tbKodepos.Text = dok.kodepos.ToString();
                    tbTelepon.Text = dok.telepon;
                    tbEmail.Text = dok.email;
                    btnTambah.Text = "UBAH";
                }

                else
                {
                    va.clear("tbIdDokter");
                    btnTambah.Text = "TAMBAH";
                }
            }
        }

        private void aksi(String aksinya)
        {
            dok = aksinya == "insert" ? new tbl_Dokter() : db.tbl_Dokters.FirstOrDefault(x => x.id_dokter == int.Parse(tbIdDokter.Text));
            dok.nama = tbNama.Text;
            dok.jenis_kelamin = cmbJeniskelamin.Text;
            dok.tanggal_lahir = dtpTanggallahir.Value;
            dok.alamat = rtbAlamat.Text;
            dok.kota = tbKota.Text;
            dok.kodepos = int.Parse(tbKodepos.Text);
            dok.telepon = tbTelepon.Text;
            dok.email = tbEmail.Text;
            if(aksinya == "insert")
            {
                dok.id_dokter = int.Parse(tbIdDokter.Text);
                db.tbl_Dokters.InsertOnSubmit(dok);
            }

            db.SubmitChanges();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                String pesan = "";
                if (va.doValidation() == false) return;
                dok = db.tbl_Dokters.FirstOrDefault(x => x.id_dokter == int.Parse(tbIdDokter.Text));
                if (dok == null)
                {
                    aksi("insert");
                    pesan = "menambah";
                }

                else
                {
                    aksi("update");
                    pesan = "memperbaharui";
                }

                MessageBox.Show("berhasil " + pesan + " data", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadGrid();
                va.clear("");
            }

            catch (Exception err)
            {
                MessageBox.Show("Terjadi Kesalahan", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDokter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
        }

        private void tbIdDokter_TextChanged(object sender, EventArgs e)
        {
            setTextbox();
        }

        private void dgvDokter_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
            if(klik == 1)
            {
                foreach(DataGridViewRow rw in this.dgvDokter.SelectedRows)
                {
                    tbIdDokter.Text = rw.Cells[0].Value.ToString();
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
                foreach(DataGridViewRow rw in this.dgvDokter.SelectedRows)
                {
                    primary = rw.Cells[0].Value.ToString();
                }

                dok = db.tbl_Dokters.Where(x => x.id_dokter == int.Parse(primary)).Single();
                db.tbl_Dokters.DeleteOnSubmit(dok);
                db.SubmitChanges();
                loadGrid();
            }

            else
            {
                MessageBox.Show("Silahkan pilih baris yang ingin dihapus", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbIdDokter_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }

        private void tbKodepos_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }

        private void tbTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }

        private void frmDokter_Load(object sender, EventArgs e)
        {
            loadGrid();
        }


    }
}

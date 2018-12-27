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
    public partial class frmUser : Form
    {
        FluorideDBDataContext db = new FluorideDBDataContext();
        frmUtama frm;
        validasi va;
        tbl_User us;
        String primary;
        int klik = 0;

        public frmUser()
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
        }
        public frmUser(frmUtama frm)
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
            this.frm = frm;
        }

        private void loadGrid()
        {
            dgvUser.DataSource = db.tbl_Users.ToList();
        }

        private void setTextBox()
        {
            if(!String.IsNullOrEmpty(tbIduser.Text))
            {
                us = db.tbl_Users.FirstOrDefault(x => x.id_user == int.Parse(tbIduser.Text));
                if(us != null)
                {
                    tbIduser.Text = us.id_user.ToString();
                    tbNama.Text = us.nama;
                    cmbJeniskelamin.Text = us.jenis_kelamin;
                    dtpTgllahir.Value = us.tanggal_lahir;
                    rtbAlamat.Text = us.alamat;
                    tbKota.Text = us.kota;
                    tbKodepos.Text = us.kodepos.ToString();
                    tbTelepon.Text = us.telepon;
                    tbEmail.Text = us.email;
                }

                else
                {
                    va.clear("tbIduser");
                }
            }
        }

        private void aksi(String aksinya)
        {
            us = aksinya == "insert" ? new tbl_User() : db.tbl_Users.FirstOrDefault(x => x.id_user == int.Parse(tbIduser.Text));
            us.nama = tbNama.Text;
            us.jenis_kelamin = cmbJeniskelamin.Text;
            us.tanggal_lahir = dtpTgllahir.Value;
            us.alamat = rtbAlamat.Text;
            us.kota = tbKota.Text;
            us.kodepos = int.Parse(tbKodepos.Text);
            us.telepon = tbTelepon.Text;
            us.email = tbEmail.Text;
            if(aksinya == "insert")
            {
                us.id_user = int.Parse(tbIduser.Text);
                db.tbl_Users.InsertOnSubmit(us);
            }

            db.SubmitChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String pesan = "";
                if (va.doValidation() == false) return;
                us = db.tbl_Users.FirstOrDefault(x => x.id_user == int.Parse(tbIduser.Text));
                if(us == null)
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

            catch(Exception err)
            {
                MessageBox.Show("Terjadi Kesalahan", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
        }

        private void dgvUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
            if (klik == 1)
            {
                foreach(DataGridViewRow rw in this.dgvUser.SelectedRows)
                {
                    tbIduser.Text = rw.Cells[0].Value.ToString();
                }
                setTextBox();
            }

            else
            {
                MessageBox.Show("Silahkan pilih baris", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbIduser_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void tbIduser_TextChanged(object sender, EventArgs e)
        {
            setTextBox();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (klik == 1)
            {
                foreach (DataGridViewRow rw in this.dgvUser.SelectedRows)
                {
                    primary = rw.Cells[0].Value.ToString();
                }
                us = db.tbl_Users.Where(x => x.id_user == int.Parse(primary)).Single();
                db.tbl_Users.DeleteOnSubmit(us);
                db.SubmitChanges();
                loadGrid();
            }

            else
            {
                MessageBox.Show("Silahkan pilih baris", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbKodepos_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }

        private void tbTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }


    }
}

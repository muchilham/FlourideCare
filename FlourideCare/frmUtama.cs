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
    public partial class frmUtama : Form
    {
        public frmUtama()
        {
            InitializeComponent();
        }

        private void active(Button btn)
        {
            foreach(Control ctl in this.subheader.Controls)
            {
                if(ctl.Equals(btn))
                {
                    ctl.BackColor = Color.MediumBlue;
                }

                else
                {
                    ctl.BackColor = Color.Blue;
                }
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            active(btnUser);
            this.body.Controls.Clear();
            frmUser frm = new frmUser();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void btnDokter_Click(object sender, EventArgs e)
        {
            active(btnDokter);
            this.body.Controls.Clear();
            frmDokter frm = new frmDokter();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            active(btnJadwal);
            this.body.Controls.Clear();
            frmJadwal frm = new frmJadwal();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void btnJenis_Click(object sender, EventArgs e)
        {
            active(btnJenis);
            this.body.Controls.Clear();
            frmJenis frm = new frmJenis();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void btnRuangan_Click(object sender, EventArgs e)
        {
            active(btnRuangan);
            this.body.Controls.Clear();
            frmRuangan frm = new frmRuangan();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void btnAntrian_Click(object sender, EventArgs e)
        {
            active(btnAntrian);
            this.body.Controls.Clear();
            frmAntrian frm = new frmAntrian();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void btnDiagnosa_Click(object sender, EventArgs e)
        {
            active(btnDiagnosa);
            this.body.Controls.Clear();
            frmDiagnosa frm = new frmDiagnosa();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void btnObat_Click(object sender, EventArgs e)
        {
            active(btnObat);
            this.body.Controls.Clear();
            frmObat frm = new frmObat();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            active(btnPembayaran);
            this.body.Controls.Clear();
            frmPembayaran frm = new frmPembayaran();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            active(btnLaporan);
            this.body.Controls.Clear();
            frmUser frm = new frmUser();
            frm.Show();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.body.Controls.Add(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult fk = MessageBox.Show("Apakah anda yakin ingin keluar dari aplikasi ini", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (fk == DialogResult.No) return;
            Application.ExitThread();
        }
    }
}

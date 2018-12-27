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
    public partial class frmPembayaran : Form
    {
        FluorideDBDataContext db = new FluorideDBDataContext();
        String idDiagnosa;
        int klik = 0;
        public frmPembayaran()
        {
            InitializeComponent();
        }

        private void loadGrid()
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
                                      where d.status == "BELUM DIBAYAR"
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
        }

        private void dgvDiagnosa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if(klik == 1)
            {
                foreach(DataGridViewRow rw in this.dgvDiagnosa.SelectedRows)
                {
                    idDiagnosa = rw.Cells[0].Value.ToString();
                }

                frmPembayaranDetail frm = new frmPembayaranDetail(idDiagnosa);
                frm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Silahkan pilih baris yang ingin dipilih!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDiagnosa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            klik = 1;
            btnBayar_Click(sender , e);
        }

        private void frmPembayaran_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
    }
}

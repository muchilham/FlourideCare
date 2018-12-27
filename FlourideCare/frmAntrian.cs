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
    public partial class frmAntrian : Form
    {
        FluorideDBDataContext db = new FluorideDBDataContext();
        frmUtama frm;
        validasi va;
        tbl_Antrian an;
        String primary, dokter, tipe;
        public frmAntrian()
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
        }

        public frmAntrian(frmUtama frm)
        {
            InitializeComponent();
            va = new validasi(this.Controls, this.eValidasi);
            this.frm = frm;
        }

        public void loadGrid()
        {
            dgvAntrian.DataSource = (from a in
                                         (from a in db.tbl_Antrians
                                          where a.tanggal == DateTime.Now
                                          select new
                                          {
                                              Tanggal = a.tanggal,
                                              No =  a.no_antrian,
                                              Ruangan = a.id_ruangan,
                                              IDUser = a.id_user,
                                              Column1 = (int?)Convert.ToInt32(a.no_antrian.Substring(2 + 6 - 1, (int)a.no_antrian.Length - 1)),
                                              Dummy = "x"
                                          })
                                     join r in db.tbl_Ruangans
                                     on a.Ruangan equals r.id_ruangan
                                     orderby a.Ruangan, a.Column1
                                     select new

                                     {
                                         a.No,
                                         a.IDUser,
                                         Ruangan = r.id_ruangan,
                                         a.Tanggal
                                     }).ToList();

            cmbIdruangan.DataSource = from r in db.tbl_Ruangans 
                                      join j in db.tbl_Jadwals
                                      on r.id_jadwal equals j.id_jadwal
                                      where (j.mulai < TimeSpan.Parse(DateTime.Now.ToString("HH:mm")) && j.selesai > TimeSpan.Parse(DateTime.Now.ToString("HH:mm")))
                                      select r.id_ruangan;
            cmbIduser.DataSource = from u in db.tbl_Users select u.id_user;
        }

        private void cmbIdruangan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (db.tbl_Antrians.Where(i => i.id_ruangan == cmbIdruangan.Text).Count() > 0)
            {
                if (db.tbl_Antrians.Any(x => x.tanggal == DateTime.Now))
                {
                    var setprimary = from a in
                                         (from a in db.tbl_Antrians
                                          where a.id_ruangan == cmbIdruangan.Text
                                          select new
                                          {
                                              Ruangan = a.id_ruangan,
                                              Column1 = (int?)Convert.ToInt32(a.no_antrian.Substring(2 + 6 - 1, (int)a.no_antrian.Length - 1)),
                                              Dummy = "x"
                                          })
                                     group a by new { a.Dummy } into g
                                     select new
                                     {
                                         ruang = g.First().Ruangan,
                                         kode = (int?)g.Max(p => p.Column1 + 1)
                                     };
                    foreach (var b in setprimary)
                    {
                        primary = "Antrian " + b.kode.ToString();
                    }
                }

                else
                {
                    primary = "Antrian " + 1;
                }
            }

            else
            {
                primary = "Antrian " + 1;
            }

            var query = from r in db.tbl_Ruangans
                        join d in db.tbl_Dokters
                        on r.id_dokter equals d.id_dokter

                        join t in db.tbl_tipes
                        on r.id_tipe equals t.id_tipe
                        where r.id_ruangan == cmbIdruangan.Text
                        select new
                        {
                            dokter = d.nama,
                            tipe = t.nama
                        };
            foreach(var v in query)
            {
                tbNamadokter.Text = v.dokter;
                tbJenisdokter.Text = v.tipe;
                
            }
            tbNo.Text = primary;
        }

        public void frmAntrian_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (va.doValidation() == false || cmbIdruangan.Text == "") return;
                an = new tbl_Antrian
                {
                    no_antrian = tbNo.Text,
                    id_ruangan = cmbIdruangan.Text,
                    id_user = int.Parse(cmbIduser.Text),
                    tanggal = DateTime.Now
                };
                db.tbl_Antrians.InsertOnSubmit(an);
                db.SubmitChanges();
                MessageBox.Show("Berhasil menambah data", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadGrid();
            }

            catch (Exception err)
            {
                MessageBox.Show("Terjadi Kesalahan" + err.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbIduser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(cmbIduser.Text))
            {
                var query = from us in db.tbl_Users
                            where us.id_user == int.Parse(cmbIduser.Text)
                            select us;
                foreach (var g in query)
                {
                    tbNamapasien.Text = g.nama;
                }
            }

        }
    }
}

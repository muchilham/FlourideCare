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
    public partial class frmPembayaranDetail : Form
    {
        FluorideDBDataContext db = new FluorideDBDataContext();
        String idDiagnosa, primary, resepobat, idObat;
        tbl_PembayaranMaster pm;
        tbl_PembayaranDetail pd;
        tbl_Obat o;
        validasi va;
        int klik = 0;
        double total;
        public frmPembayaranDetail(String idDiagnosa)
        {
            InitializeComponent();
            this.idDiagnosa = idDiagnosa;
        }

        private void load()
        {
            if(db.tbl_PembayaranMasters.Count() > 0)
            {
                var setPrimary = from pm in
                                     (
                                        from pm in db.tbl_PembayaranMasters
                                        select new
                                        {
                                            Column1 = (int?)Convert.ToInt32(pm.id_pembayaran.Substring(2 + 3 - 1, (int)pm.id_pembayaran.Length - 1)),
                                            Dummy = "x"
                                        })
                                 group pm by new { pm.Dummy } into g
                                 select new
                                 {
                                     kode = (int?)g.Max(p => p.Column1 + 1)
                                 };
                foreach(var v in setPrimary)
                {
                    primary = "PM - " + v.kode.ToString();
                }
            }

            else
            {
                primary = "PM - " + 1;
            }

            tbIdpembayaran.Text = primary;
            tbIddiagnosa.Text = idDiagnosa;
            var resep = from d in db.tbl_Diagnosas
                        where d.id_diagnosa == idDiagnosa
                        select d;
            foreach(var h in resep)
            {
                resepobat = h.resep;
            }
            rtbResep.Text = resepobat;

            cmbIdobat.DataSource = from o in db.tbl_Obats select o.id_obat;
        }

        private void setTextbox()
        {
            for(int i = 0; i < lvObat.Items.Count; i++)
            {
                if(lvObat.Items[i].SubItems[0].Text == cmbIdobat.Text)
                {
                    nupStok.Value = int.Parse(lvObat.Items[i].SubItems[3].Text);
                }
            }
        }

        private void frmPembayaranDetail_Load(object sender, EventArgs e)
        {
            load();
        }

        private void cmbIdobat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(cmbIdobat.Text))
            {
                setTextbox();
                tbl_Obat ob = db.tbl_Obats.FirstOrDefault(x => x.id_obat == int.Parse(cmbIdobat.Text));
                tbNamaobat.Text = ob.nama_obat;
                tbHargaobat.Text = ob.harga.ToString();
                tbStokobat.Text = ob.stok.ToString();
            }
        }

        private void nupStok_ValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbStokobat.Text))
            {
                if (nupStok.Value >= int.Parse(tbStokobat.Text))
                {
                    MessageBox.Show("Tidak boleh melebihi batas stok", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nupStok.Value = 1;
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            double harga;
            va = new validasi(this.groupBox1.Controls, this.eValidasi);
            if (va.doValidation() == false) return;
            for (int i = 0; i < lvObat.Items.Count; i++)
            {
                if (lvObat.Items[i].SubItems[0].Text == cmbIdobat.Text)
                {
                    lvObat.Items[i].Remove();
                }
            }
            ListViewItem lv = new ListViewItem(cmbIdobat.Text);
            lv.SubItems.Add(tbNamaobat.Text);
            lv.SubItems.Add(tbHargaobat.Text);
            lv.SubItems.Add(nupStok.Value.ToString());
            harga = Double.Parse(tbHargaobat.Text) * (int)nupStok.Value;
            lv.SubItems.Add(harga.ToString());
            lvObat.Items.Add(lv);
            va.clear("cmbIdobat");

            if (lvObat.Items.Count == 1)
            {
                tbTotal.Text = lvObat.Items[0].SubItems[4].Text;
            }

            else
            {
                for (int i = 1; i < lvObat.Items.Count; i++)
                {
                    tbTotal.Text = (int.Parse(tbTotal.Text) + int.Parse(lvObat.Items[i].SubItems[4].Text)).ToString();
                }
            }
            btnHapus.Enabled = true;
        }

        private void lvObat_Click(object sender, EventArgs e)
        {
            klik = 1;
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(klik == 1)
            {
                int subtotal = 0;
                if(lvObat.Items.Count == 0)
                {
                    tbHarga.Text = "0";
                    btnHapus.Enabled = false;
                }
                else
                {
                    foreach(ListViewItem lv in this.lvObat.SelectedItems)
                    {
                        idObat = lv.SubItems[0].Text;
                    }
                    lvObat.FocusedItem.Remove();

                    if (lvObat.Items.Count > 0)
                    {
                        for (int i = 0; i < lvObat.Items.Count; i++)
                        {
                            subtotal += int.Parse(lvObat.Items[i].SubItems[4].Text);
                            tbTotal.Text = subtotal.ToString();
                        }
                    }

                    else
                    {
                        tbTotal.Text = "0";
                    }
                }
            }

            else
            {
                MessageBox.Show("Silahkan pilih baris yang ingin dihapus", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            va = new validasi(this.groupBox2.Controls, this.eValidasi);
            va.numberFormat(e);
        }

        private void tbHarga_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbHarga.Text))
            {
                tbTotal.Text = (int.Parse(tbTotal.Text) + int.Parse(tbHarga.Text)).ToString();
            }

            else
            {
                if (lvObat.Items.Count == 1)
                {
                    tbTotal.Text = lvObat.Items[0].SubItems[4].Text;
                }

                else
                {
                    for (int i = 1; i < lvObat.Items.Count; i++)
                    {
                        tbTotal.Text = (int.Parse(tbTotal.Text) + int.Parse(lvObat.Items[i].SubItems[4].Text)).ToString();
                    }
                }
            }
        }

        private void aksi()
        {
            pm = new tbl_PembayaranMaster
            {
                id_pembayaran = tbIdpembayaran.Text,
                id_diagnosa = tbIddiagnosa.Text,
                total = Double.Parse(tbTotal.Text),
                waktu_pembayaran = DateTime.Now
            };
            db.tbl_PembayaranMasters.InsertOnSubmit(pm);
            db.SubmitChanges();

            var updatediagnosa = db.tbl_Diagnosas.FirstOrDefault(i => i.id_diagnosa == tbIddiagnosa.Text);
            updatediagnosa.status = "SUDAH DIBAYAR";

            foreach (ListViewItem li in lvObat.Items)
            {
                pd = new tbl_PembayaranDetail
                {
                    id_pembayaran = tbIdpembayaran.Text,
                    id_obat = int.Parse(li.SubItems[0].Text),
                    jumlah = int.Parse(li.SubItems[3].Text),
                    harga = float.Parse(li.SubItems[4].Text)
                };

                var update = db.tbl_Obats.FirstOrDefault(i => i.id_obat == int.Parse(li.SubItems[0].Text));
                update.stok = update.stok - int.Parse(li.SubItems[3].Text);
                db.tbl_PembayaranDetails.InsertOnSubmit(pd);
                db.SubmitChanges();
            }

        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            try
            {
                va = new validasi(this.groupBox2.Controls, this.eValidasi);
                if (va.doValidation() == false) return;
                if(int.Parse(textBox1.Text) <= int.Parse(tbTotal.Text))
                {
                    MessageBox.Show("Uang anda tidak mencukupi!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                aksi();
                String kembali = (int.Parse(textBox1.Text) - int.Parse(tbTotal.Text)).ToString();
                MessageBox.Show(" Berhasil melakukan pembayaran\n Kembalian anda adalah Rp." + kembali + "\n Terima kasih", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            catch(Exception err)
            {
                MessageBox.Show("Terjadi kesalahan", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            va = new validasi(this.groupBox2.Controls, this.eValidasi);
            va.numberFormat(e);
        }
    }
}

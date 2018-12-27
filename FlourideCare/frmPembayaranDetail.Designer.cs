namespace FlourideCare
{
    partial class frmPembayaranDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvObat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbIdobat = new System.Windows.Forms.ComboBox();
            this.tbNamaobat = new System.Windows.Forms.TextBox();
            this.tbHargaobat = new System.Windows.Forms.TextBox();
            this.tbStokobat = new System.Windows.Forms.TextBox();
            this.nupStok = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbIdpembayaran = new System.Windows.Forms.TextBox();
            this.btnBayar = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbResep = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIddiagnosa = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupStok)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).BeginInit();
            this.SuspendLayout();
            // 
            // lvObat
            // 
            this.lvObat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvObat.FullRowSelect = true;
            this.lvObat.GridLines = true;
            this.lvObat.Location = new System.Drawing.Point(323, 31);
            this.lvObat.Name = "lvObat";
            this.lvObat.Size = new System.Drawing.Size(462, 514);
            this.lvObat.TabIndex = 0;
            this.lvObat.UseCompatibleStateImageBehavior = false;
            this.lvObat.View = System.Windows.Forms.View.Details;
            this.lvObat.Click += new System.EventHandler(this.lvObat_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Obat";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nama Obat";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Harga Obat";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Jumlah";
            this.columnHeader4.Width = 81;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total Harga";
            this.columnHeader5.Width = 87;
            // 
            // cmbIdobat
            // 
            this.cmbIdobat.FormattingEnabled = true;
            this.cmbIdobat.Location = new System.Drawing.Point(127, 31);
            this.cmbIdobat.Name = "cmbIdobat";
            this.cmbIdobat.Size = new System.Drawing.Size(149, 21);
            this.cmbIdobat.TabIndex = 1;
            this.cmbIdobat.SelectedIndexChanged += new System.EventHandler(this.cmbIdobat_SelectedIndexChanged);
            // 
            // tbNamaobat
            // 
            this.tbNamaobat.Enabled = false;
            this.tbNamaobat.Location = new System.Drawing.Point(127, 59);
            this.tbNamaobat.Name = "tbNamaobat";
            this.tbNamaobat.ReadOnly = true;
            this.tbNamaobat.Size = new System.Drawing.Size(149, 20);
            this.tbNamaobat.TabIndex = 2;
            // 
            // tbHargaobat
            // 
            this.tbHargaobat.Enabled = false;
            this.tbHargaobat.Location = new System.Drawing.Point(127, 85);
            this.tbHargaobat.Name = "tbHargaobat";
            this.tbHargaobat.ReadOnly = true;
            this.tbHargaobat.Size = new System.Drawing.Size(149, 20);
            this.tbHargaobat.TabIndex = 3;
            // 
            // tbStokobat
            // 
            this.tbStokobat.Enabled = false;
            this.tbStokobat.Location = new System.Drawing.Point(127, 111);
            this.tbStokobat.Name = "tbStokobat";
            this.tbStokobat.ReadOnly = true;
            this.tbStokobat.Size = new System.Drawing.Size(149, 20);
            this.tbStokobat.TabIndex = 4;
            // 
            // nupStok
            // 
            this.nupStok.Location = new System.Drawing.Point(127, 137);
            this.nupStok.Name = "nupStok";
            this.nupStok.Size = new System.Drawing.Size(149, 20);
            this.nupStok.TabIndex = 5;
            this.nupStok.ValueChanged += new System.EventHandler(this.nupStok_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama Obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Harga Obat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stok Obat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jumlah";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.Controls.Add(this.cmbIdobat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbNamaobat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbHargaobat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbStokobat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nupStok);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 217);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Obat";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Blue;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(127, 163);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 58;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbIdpembayaran);
            this.groupBox2.Controls.Add(this.btnBayar);
            this.groupBox2.Controls.Add(this.tbTotal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbHarga);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rtbResep);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbIddiagnosa);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 291);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pembayaran";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "ID Pembayaran";
            // 
            // tbIdpembayaran
            // 
            this.tbIdpembayaran.Enabled = false;
            this.tbIdpembayaran.Location = new System.Drawing.Point(127, 28);
            this.tbIdpembayaran.Name = "tbIdpembayaran";
            this.tbIdpembayaran.ReadOnly = true;
            this.tbIdpembayaran.Size = new System.Drawing.Size(149, 20);
            this.tbIdpembayaran.TabIndex = 66;
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.Color.Blue;
            this.btnBayar.FlatAppearance.BorderSize = 0;
            this.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.Location = new System.Drawing.Point(127, 231);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(75, 23);
            this.btnBayar.TabIndex = 59;
            this.btnBayar.Text = "BAYAR";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(127, 179);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(149, 20);
            this.tbTotal.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Total Harga";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(127, 153);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(149, 20);
            this.tbHarga.TabIndex = 63;
            this.tbHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHarga_KeyPress);
            this.tbHarga.Leave += new System.EventHandler(this.tbHarga_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Harga Diagnosa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Resep Obat";
            // 
            // rtbResep
            // 
            this.rtbResep.Enabled = false;
            this.rtbResep.Location = new System.Drawing.Point(127, 81);
            this.rtbResep.Name = "rtbResep";
            this.rtbResep.ReadOnly = true;
            this.rtbResep.Size = new System.Drawing.Size(149, 66);
            this.rtbResep.TabIndex = 60;
            this.rtbResep.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "ID Diagnosa";
            // 
            // tbIddiagnosa
            // 
            this.tbIddiagnosa.Enabled = false;
            this.tbIddiagnosa.Location = new System.Drawing.Point(127, 54);
            this.tbIddiagnosa.Name = "tbIddiagnosa";
            this.tbIddiagnosa.ReadOnly = true;
            this.tbIddiagnosa.Size = new System.Drawing.Size(149, 20);
            this.tbIddiagnosa.TabIndex = 0;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Blue;
            this.btnHapus.Enabled = false;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(710, 551);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 59;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // eValidasi
            // 
            this.eValidasi.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 69;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Dibayar dengan";
            // 
            // frmPembayaranDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 586);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvObat);
            this.Name = "frmPembayaranDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPembayaranDetail";
            this.Load += new System.EventHandler(this.frmPembayaranDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupStok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvObat;
        private System.Windows.Forms.ComboBox cmbIdobat;
        private System.Windows.Forms.TextBox tbNamaobat;
        private System.Windows.Forms.TextBox tbHargaobat;
        private System.Windows.Forms.TextBox tbStokobat;
        private System.Windows.Forms.NumericUpDown nupStok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbIdpembayaran;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbResep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIddiagnosa;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.ErrorProvider eValidasi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
    }
}
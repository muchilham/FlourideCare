namespace FlourideCare
{
    partial class frmDokter
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDokter = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbAlamat = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTanggallahir = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbJeniskelamin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelepon = new System.Windows.Forms.TextBox();
            this.tbKodepos = new System.Windows.Forms.TextBox();
            this.tbKota = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbIdDokter = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data Dokter";
            // 
            // dgvDokter
            // 
            this.dgvDokter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDokter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDokter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDokter.Location = new System.Drawing.Point(357, 136);
            this.dgvDokter.Name = "dgvDokter";
            this.dgvDokter.ReadOnly = true;
            this.dgvDokter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDokter.Size = new System.Drawing.Size(409, 234);
            this.dgvDokter.TabIndex = 2;
            this.dgvDokter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDokter_CellContentClick);
            this.dgvDokter.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDokter_CellContentDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Telepon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "Kode Pos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Kota";
            // 
            // rtbAlamat
            // 
            this.rtbAlamat.Location = new System.Drawing.Point(165, 240);
            this.rtbAlamat.Name = "rtbAlamat";
            this.rtbAlamat.Size = new System.Drawing.Size(152, 50);
            this.rtbAlamat.TabIndex = 39;
            this.rtbAlamat.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Alamat";
            // 
            // dtpTanggallahir
            // 
            this.dtpTanggallahir.CustomFormat = "dd/MM/yy";
            this.dtpTanggallahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggallahir.Location = new System.Drawing.Point(165, 214);
            this.dtpTanggallahir.Name = "dtpTanggallahir";
            this.dtpTanggallahir.Size = new System.Drawing.Size(152, 20);
            this.dtpTanggallahir.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tanggal Lahir";
            // 
            // cmbJeniskelamin
            // 
            this.cmbJeniskelamin.FormattingEnabled = true;
            this.cmbJeniskelamin.Items.AddRange(new object[] {
            "Laki - laki",
            "Perempuan"});
            this.cmbJeniskelamin.Location = new System.Drawing.Point(165, 187);
            this.cmbJeniskelamin.Name = "cmbJeniskelamin";
            this.cmbJeniskelamin.Size = new System.Drawing.Size(152, 21);
            this.cmbJeniskelamin.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID Dokter";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Blue;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(165, 401);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 31;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(165, 374);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(152, 20);
            this.tbEmail.TabIndex = 30;
            // 
            // tbTelepon
            // 
            this.tbTelepon.Location = new System.Drawing.Point(165, 348);
            this.tbTelepon.Name = "tbTelepon";
            this.tbTelepon.Size = new System.Drawing.Size(152, 20);
            this.tbTelepon.TabIndex = 29;
            this.tbTelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelepon_KeyPress);
            // 
            // tbKodepos
            // 
            this.tbKodepos.Location = new System.Drawing.Point(165, 322);
            this.tbKodepos.Name = "tbKodepos";
            this.tbKodepos.Size = new System.Drawing.Size(152, 20);
            this.tbKodepos.TabIndex = 28;
            this.tbKodepos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKodepos_KeyPress);
            // 
            // tbKota
            // 
            this.tbKota.Location = new System.Drawing.Point(165, 296);
            this.tbKota.Name = "tbKota";
            this.tbKota.Size = new System.Drawing.Size(152, 20);
            this.tbKota.TabIndex = 27;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(165, 162);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(152, 20);
            this.tbNama.TabIndex = 26;
            // 
            // tbIdDokter
            // 
            this.tbIdDokter.Location = new System.Drawing.Point(165, 136);
            this.tbIdDokter.Name = "tbIdDokter";
            this.tbIdDokter.Size = new System.Drawing.Size(152, 20);
            this.tbIdDokter.TabIndex = 25;
            this.tbIdDokter.TextChanged += new System.EventHandler(this.tbIdDokter_TextChanged);
            this.tbIdDokter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdDokter_KeyPress);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHapus.BackColor = System.Drawing.Color.Blue;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(691, 376);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 44;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // eValidasi
            // 
            this.eValidasi.ContainerControl = this;
            // 
            // frmDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 436);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbAlamat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpTanggallahir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbJeniskelamin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelepon);
            this.Controls.Add(this.tbKodepos);
            this.Controls.Add(this.tbKota);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbIdDokter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDokter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDokter";
            this.Text = "frmDokter";
            this.Load += new System.EventHandler(this.frmDokter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDokter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbAlamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTanggallahir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbJeniskelamin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelepon;
        private System.Windows.Forms.TextBox tbKodepos;
        private System.Windows.Forms.TextBox tbKota;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbIdDokter;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.ErrorProvider eValidasi;
    }
}
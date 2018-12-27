namespace FlourideCare
{
    partial class frmUtama
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
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.subheader = new System.Windows.Forms.Panel();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnPembayaran = new System.Windows.Forms.Button();
            this.btnObat = new System.Windows.Forms.Button();
            this.btnDiagnosa = new System.Windows.Forms.Button();
            this.btnAntrian = new System.Windows.Forms.Button();
            this.btnRuangan = new System.Windows.Forms.Button();
            this.btnJenis = new System.Windows.Forms.Button();
            this.btnJadwal = new System.Windows.Forms.Button();
            this.btnDokter = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.body = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.subheader.SuspendLayout();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Blue;
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.button1);
            this.header.Controls.Add(this.subheader);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1132, 112);
            this.header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(483, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fluoride Care";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1092, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subheader
            // 
            this.subheader.BackColor = System.Drawing.Color.Blue;
            this.subheader.Controls.Add(this.btnLaporan);
            this.subheader.Controls.Add(this.btnPembayaran);
            this.subheader.Controls.Add(this.btnObat);
            this.subheader.Controls.Add(this.btnDiagnosa);
            this.subheader.Controls.Add(this.btnAntrian);
            this.subheader.Controls.Add(this.btnRuangan);
            this.subheader.Controls.Add(this.btnJenis);
            this.subheader.Controls.Add(this.btnJadwal);
            this.subheader.Controls.Add(this.btnDokter);
            this.subheader.Controls.Add(this.btnUser);
            this.subheader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.subheader.Location = new System.Drawing.Point(0, 72);
            this.subheader.Name = "subheader";
            this.subheader.Size = new System.Drawing.Size(1132, 40);
            this.subheader.TabIndex = 0;
            // 
            // btnLaporan
            // 
            this.btnLaporan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(997, 0);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(112, 40);
            this.btnLaporan.TabIndex = 9;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnPembayaran
            // 
            this.btnPembayaran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPembayaran.FlatAppearance.BorderSize = 0;
            this.btnPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembayaran.ForeColor = System.Drawing.Color.White;
            this.btnPembayaran.Location = new System.Drawing.Point(882, 0);
            this.btnPembayaran.Name = "btnPembayaran";
            this.btnPembayaran.Size = new System.Drawing.Size(112, 40);
            this.btnPembayaran.TabIndex = 8;
            this.btnPembayaran.Text = "Pembayaran";
            this.btnPembayaran.UseVisualStyleBackColor = true;
            this.btnPembayaran.Click += new System.EventHandler(this.btnPembayaran_Click);
            // 
            // btnObat
            // 
            this.btnObat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObat.FlatAppearance.BorderSize = 0;
            this.btnObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObat.ForeColor = System.Drawing.Color.White;
            this.btnObat.Location = new System.Drawing.Point(767, 0);
            this.btnObat.Name = "btnObat";
            this.btnObat.Size = new System.Drawing.Size(112, 40);
            this.btnObat.TabIndex = 7;
            this.btnObat.Text = "Data Obat";
            this.btnObat.UseVisualStyleBackColor = true;
            this.btnObat.Click += new System.EventHandler(this.btnObat_Click);
            // 
            // btnDiagnosa
            // 
            this.btnDiagnosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiagnosa.FlatAppearance.BorderSize = 0;
            this.btnDiagnosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosa.ForeColor = System.Drawing.Color.White;
            this.btnDiagnosa.Location = new System.Drawing.Point(652, 0);
            this.btnDiagnosa.Name = "btnDiagnosa";
            this.btnDiagnosa.Size = new System.Drawing.Size(112, 40);
            this.btnDiagnosa.TabIndex = 6;
            this.btnDiagnosa.Text = "Data Diagnosa";
            this.btnDiagnosa.UseVisualStyleBackColor = true;
            this.btnDiagnosa.Click += new System.EventHandler(this.btnDiagnosa_Click);
            // 
            // btnAntrian
            // 
            this.btnAntrian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAntrian.FlatAppearance.BorderSize = 0;
            this.btnAntrian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntrian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntrian.ForeColor = System.Drawing.Color.White;
            this.btnAntrian.Location = new System.Drawing.Point(570, 0);
            this.btnAntrian.Name = "btnAntrian";
            this.btnAntrian.Size = new System.Drawing.Size(79, 40);
            this.btnAntrian.TabIndex = 5;
            this.btnAntrian.Text = "Antrian";
            this.btnAntrian.UseVisualStyleBackColor = true;
            this.btnAntrian.Click += new System.EventHandler(this.btnAntrian_Click);
            // 
            // btnRuangan
            // 
            this.btnRuangan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRuangan.FlatAppearance.BorderSize = 0;
            this.btnRuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuangan.ForeColor = System.Drawing.Color.White;
            this.btnRuangan.Location = new System.Drawing.Point(457, 0);
            this.btnRuangan.Name = "btnRuangan";
            this.btnRuangan.Size = new System.Drawing.Size(110, 40);
            this.btnRuangan.TabIndex = 4;
            this.btnRuangan.Text = "Data Ruangan";
            this.btnRuangan.UseVisualStyleBackColor = true;
            this.btnRuangan.Click += new System.EventHandler(this.btnRuangan_Click);
            // 
            // btnJenis
            // 
            this.btnJenis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJenis.FlatAppearance.BorderSize = 0;
            this.btnJenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJenis.ForeColor = System.Drawing.Color.White;
            this.btnJenis.Location = new System.Drawing.Point(333, 0);
            this.btnJenis.Name = "btnJenis";
            this.btnJenis.Size = new System.Drawing.Size(121, 40);
            this.btnJenis.TabIndex = 3;
            this.btnJenis.Text = "Jenis Perawatan";
            this.btnJenis.UseVisualStyleBackColor = true;
            this.btnJenis.Click += new System.EventHandler(this.btnJenis_Click);
            // 
            // btnJadwal
            // 
            this.btnJadwal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJadwal.FlatAppearance.BorderSize = 0;
            this.btnJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJadwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJadwal.ForeColor = System.Drawing.Color.White;
            this.btnJadwal.Location = new System.Drawing.Point(232, 0);
            this.btnJadwal.Name = "btnJadwal";
            this.btnJadwal.Size = new System.Drawing.Size(98, 40);
            this.btnJadwal.TabIndex = 2;
            this.btnJadwal.Text = "Data Jadwal";
            this.btnJadwal.UseVisualStyleBackColor = true;
            this.btnJadwal.Click += new System.EventHandler(this.btnJadwal_Click);
            // 
            // btnDokter
            // 
            this.btnDokter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDokter.FlatAppearance.BorderSize = 0;
            this.btnDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDokter.ForeColor = System.Drawing.Color.White;
            this.btnDokter.Location = new System.Drawing.Point(131, 0);
            this.btnDokter.Name = "btnDokter";
            this.btnDokter.Size = new System.Drawing.Size(98, 40);
            this.btnDokter.TabIndex = 1;
            this.btnDokter.Text = "Data Dokter";
            this.btnDokter.UseVisualStyleBackColor = true;
            this.btnDokter.Click += new System.EventHandler(this.btnDokter_Click);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(30, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(98, 40);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Data User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // body
            // 
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 112);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(1132, 340);
            this.body.TabIndex = 1;
            // 
            // footer
            // 
            this.footer.Controls.Add(this.label2);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 423);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1132, 29);
            this.footer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1011, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "LKS DKI Jakarta 2016";
            // 
            // frmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 452);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.body);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUtama";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.subheader.ResumeLayout(false);
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel subheader;
        private System.Windows.Forms.Button btnRuangan;
        private System.Windows.Forms.Button btnJenis;
        private System.Windows.Forms.Button btnJadwal;
        private System.Windows.Forms.Button btnDokter;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnPembayaran;
        private System.Windows.Forms.Button btnObat;
        private System.Windows.Forms.Button btnDiagnosa;
        private System.Windows.Forms.Button btnAntrian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


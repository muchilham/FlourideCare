namespace FlourideCare
{
    partial class frmRuangan
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
            this.dgvRuangan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdruangan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNamaruangan = new System.Windows.Forms.TextBox();
            this.cmbIdtipe = new System.Windows.Forms.ComboBox();
            this.cmbIddokter = new System.Windows.Forms.ComboBox();
            this.cmbIdjadwal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuangan)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Ruangan";
            // 
            // dgvRuangan
            // 
            this.dgvRuangan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRuangan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRuangan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRuangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuangan.Location = new System.Drawing.Point(357, 136);
            this.dgvRuangan.Name = "dgvRuangan";
            this.dgvRuangan.ReadOnly = true;
            this.dgvRuangan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRuangan.Size = new System.Drawing.Size(409, 234);
            this.dgvRuangan.TabIndex = 8;
            this.dgvRuangan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRuangan_CellContentClick);
            this.dgvRuangan.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRuangan_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID Ruangan";
            // 
            // tbIdruangan
            // 
            this.tbIdruangan.Enabled = false;
            this.tbIdruangan.Location = new System.Drawing.Point(165, 136);
            this.tbIdruangan.Name = "tbIdruangan";
            this.tbIdruangan.ReadOnly = true;
            this.tbIdruangan.Size = new System.Drawing.Size(118, 20);
            this.tbIdruangan.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nama Ruangan";
            // 
            // tbNamaruangan
            // 
            this.tbNamaruangan.Location = new System.Drawing.Point(165, 162);
            this.tbNamaruangan.Name = "tbNamaruangan";
            this.tbNamaruangan.Size = new System.Drawing.Size(152, 20);
            this.tbNamaruangan.TabIndex = 39;
            // 
            // cmbIdtipe
            // 
            this.cmbIdtipe.FormattingEnabled = true;
            this.cmbIdtipe.Location = new System.Drawing.Point(165, 189);
            this.cmbIdtipe.Name = "cmbIdtipe";
            this.cmbIdtipe.Size = new System.Drawing.Size(152, 21);
            this.cmbIdtipe.TabIndex = 41;
            // 
            // cmbIddokter
            // 
            this.cmbIddokter.FormattingEnabled = true;
            this.cmbIddokter.Location = new System.Drawing.Point(165, 216);
            this.cmbIddokter.Name = "cmbIddokter";
            this.cmbIddokter.Size = new System.Drawing.Size(152, 21);
            this.cmbIddokter.TabIndex = 42;
            // 
            // cmbIdjadwal
            // 
            this.cmbIdjadwal.FormattingEnabled = true;
            this.cmbIdjadwal.Location = new System.Drawing.Point(165, 243);
            this.cmbIdjadwal.Name = "cmbIdjadwal";
            this.cmbIdjadwal.Size = new System.Drawing.Size(152, 21);
            this.cmbIdjadwal.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Tipe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "ID Dokter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "ID Jadwal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Status";
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
            this.btnHapus.TabIndex = 50;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Blue;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(165, 296);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 49;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "KOSONG",
            "TERISI"});
            this.cmbStatus.Location = new System.Drawing.Point(165, 270);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(152, 21);
            this.cmbStatus.TabIndex = 51;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 20);
            this.button3.TabIndex = 52;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // eValidasi
            // 
            this.eValidasi.ContainerControl = this;
            // 
            // frmRuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 436);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIdjadwal);
            this.Controls.Add(this.cmbIddokter);
            this.Controls.Add(this.cmbIdtipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNamaruangan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdruangan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRuangan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRuangan";
            this.Text = "frmRuangan";
            this.Load += new System.EventHandler(this.frmRuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRuangan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdruangan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNamaruangan;
        private System.Windows.Forms.ComboBox cmbIdtipe;
        private System.Windows.Forms.ComboBox cmbIddokter;
        private System.Windows.Forms.ComboBox cmbIdjadwal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider eValidasi;
    }
}
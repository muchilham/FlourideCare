namespace FlourideCare
{
    partial class frmAntrian
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
            this.dgvAntrian = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbIdruangan = new System.Windows.Forms.ComboBox();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIduser = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNamadokter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbJenisdokter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNamapasien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntrian)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Antrian";
            // 
            // dgvAntrian
            // 
            this.dgvAntrian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAntrian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAntrian.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAntrian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAntrian.Location = new System.Drawing.Point(357, 136);
            this.dgvAntrian.Name = "dgvAntrian";
            this.dgvAntrian.ReadOnly = true;
            this.dgvAntrian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAntrian.Size = new System.Drawing.Size(409, 234);
            this.dgvAntrian.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nomor Antrian";
            // 
            // tbNo
            // 
            this.tbNo.Enabled = false;
            this.tbNo.Location = new System.Drawing.Point(163, 136);
            this.tbNo.Name = "tbNo";
            this.tbNo.ReadOnly = true;
            this.tbNo.Size = new System.Drawing.Size(119, 20);
            this.tbNo.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "ID Ruangan";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Blue;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(163, 295);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 50;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 20);
            this.button3.TabIndex = 51;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cmbIdruangan
            // 
            this.cmbIdruangan.FormattingEnabled = true;
            this.cmbIdruangan.Location = new System.Drawing.Point(163, 162);
            this.cmbIdruangan.Name = "cmbIdruangan";
            this.cmbIdruangan.Size = new System.Drawing.Size(151, 21);
            this.cmbIdruangan.TabIndex = 52;
            this.cmbIdruangan.SelectedIndexChanged += new System.EventHandler(this.cmbIdruangan_SelectedIndexChanged);
            // 
            // eValidasi
            // 
            this.eValidasi.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 64;
            this.label4.Text = "ID User";
            // 
            // cmbIduser
            // 
            this.cmbIduser.FormattingEnabled = true;
            this.cmbIduser.Location = new System.Drawing.Point(163, 242);
            this.cmbIduser.Name = "cmbIduser";
            this.cmbIduser.Size = new System.Drawing.Size(151, 21);
            this.cmbIduser.TabIndex = 65;
            this.cmbIduser.SelectedIndexChanged += new System.EventHandler(this.cmbIduser_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 67;
            this.label5.Text = "Nama Dokter";
            // 
            // tbNamadokter
            // 
            this.tbNamadokter.Enabled = false;
            this.tbNamadokter.Location = new System.Drawing.Point(163, 189);
            this.tbNamadokter.Name = "tbNamadokter";
            this.tbNamadokter.ReadOnly = true;
            this.tbNamadokter.Size = new System.Drawing.Size(151, 20);
            this.tbNamadokter.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 69;
            this.label6.Text = "Jenis Dokter";
            // 
            // tbJenisdokter
            // 
            this.tbJenisdokter.Enabled = false;
            this.tbJenisdokter.Location = new System.Drawing.Point(163, 215);
            this.tbJenisdokter.Name = "tbJenisdokter";
            this.tbJenisdokter.ReadOnly = true;
            this.tbJenisdokter.Size = new System.Drawing.Size(151, 20);
            this.tbJenisdokter.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 71;
            this.label7.Text = "Nama Pasien";
            // 
            // tbNamapasien
            // 
            this.tbNamapasien.Enabled = false;
            this.tbNamapasien.Location = new System.Drawing.Point(163, 269);
            this.tbNamapasien.Name = "tbNamapasien";
            this.tbNamapasien.ReadOnly = true;
            this.tbNamapasien.Size = new System.Drawing.Size(151, 20);
            this.tbNamapasien.TabIndex = 70;
            // 
            // frmAntrian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 436);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNamapasien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbJenisdokter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNamadokter);
            this.Controls.Add(this.cmbIduser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIdruangan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAntrian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAntrian";
            this.Text = "frmAntrian";
            this.Load += new System.EventHandler(this.frmAntrian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntrian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAntrian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbIdruangan;
        private System.Windows.Forms.ErrorProvider eValidasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIduser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbJenisdokter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNamadokter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNamapasien;
    }
}
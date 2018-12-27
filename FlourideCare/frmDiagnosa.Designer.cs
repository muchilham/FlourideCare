namespace FlourideCare
{
    partial class frmDiagnosa
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
            this.dgvDiagnosa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbHasil = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbIddiagnosa = new System.Windows.Forms.TextBox();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbIdantrian = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbResep = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosa)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data Diagnosa";
            // 
            // dgvDiagnosa
            // 
            this.dgvDiagnosa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiagnosa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiagnosa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDiagnosa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosa.Location = new System.Drawing.Point(357, 136);
            this.dgvDiagnosa.Name = "dgvDiagnosa";
            this.dgvDiagnosa.ReadOnly = true;
            this.dgvDiagnosa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnosa.Size = new System.Drawing.Size(409, 234);
            this.dgvDiagnosa.TabIndex = 12;
            this.dgvDiagnosa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRuangan_CellContentClick);
            this.dgvDiagnosa.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRuangan_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "ID Diagnosa";
            // 
            // rtbHasil
            // 
            this.rtbHasil.Location = new System.Drawing.Point(165, 189);
            this.rtbHasil.Name = "rtbHasil";
            this.rtbHasil.Size = new System.Drawing.Size(152, 66);
            this.rtbHasil.TabIndex = 47;
            this.rtbHasil.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "Hasil Diagnosa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "Resep Obat";
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
            this.btnHapus.TabIndex = 52;
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
            this.btnTambah.Location = new System.Drawing.Point(165, 350);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 51;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 20);
            this.button3.TabIndex = 57;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbIddiagnosa
            // 
            this.tbIddiagnosa.Enabled = false;
            this.tbIddiagnosa.Location = new System.Drawing.Point(165, 136);
            this.tbIddiagnosa.Name = "tbIddiagnosa";
            this.tbIddiagnosa.ReadOnly = true;
            this.tbIddiagnosa.Size = new System.Drawing.Size(119, 20);
            this.tbIddiagnosa.TabIndex = 56;
            // 
            // eValidasi
            // 
            this.eValidasi.ContainerControl = this;
            // 
            // cmbIdantrian
            // 
            this.cmbIdantrian.FormattingEnabled = true;
            this.cmbIdantrian.Location = new System.Drawing.Point(165, 161);
            this.cmbIdantrian.Name = "cmbIdantrian";
            this.cmbIdantrian.Size = new System.Drawing.Size(151, 21);
            this.cmbIdantrian.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nomor Antrian";
            // 
            // rtbResep
            // 
            this.rtbResep.Location = new System.Drawing.Point(165, 261);
            this.rtbResep.Name = "rtbResep";
            this.rtbResep.Size = new System.Drawing.Size(152, 83);
            this.rtbResep.TabIndex = 65;
            this.rtbResep.Text = "";
            // 
            // frmDiagnosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 436);
            this.Controls.Add(this.rtbResep);
            this.Controls.Add(this.cmbIdantrian);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbIddiagnosa);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbHasil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDiagnosa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiagnosa";
            this.Text = "frmDiagnosa";
            this.Load += new System.EventHandler(this.frmDiagnosa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDiagnosa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbHasil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbIddiagnosa;
        private System.Windows.Forms.ErrorProvider eValidasi;
        private System.Windows.Forms.ComboBox cmbIdantrian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbResep;
    }
}
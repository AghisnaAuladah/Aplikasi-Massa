
namespace aplikasi_massa
{
    partial class AplikasiKonversiMassa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDari = new System.Windows.Forms.ComboBox();
            this.cmbKe = new System.Windows.Forms.ComboBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aplikasi Konversi Massa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(58, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(58, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ke";
            // 
            // cmbDari
            // 
            this.cmbDari.FormattingEnabled = true;
            this.cmbDari.Items.AddRange(new object[] {
            "Ton",
            "Kilogram",
            "Gram",
            "Ons"});
            this.cmbDari.Location = new System.Drawing.Point(111, 139);
            this.cmbDari.Name = "cmbDari";
            this.cmbDari.Size = new System.Drawing.Size(182, 21);
            this.cmbDari.TabIndex = 3;
            this.cmbDari.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbKe
            // 
            this.cmbKe.FormattingEnabled = true;
            this.cmbKe.Items.AddRange(new object[] {
            "Ton",
            "Kilogram",
            "Gram",
            "Ons"});
            this.cmbKe.Location = new System.Drawing.Point(111, 182);
            this.cmbKe.Name = "cmbKe";
            this.cmbKe.Size = new System.Drawing.Size(182, 21);
            this.cmbKe.TabIndex = 4;
            // 
            // btnHitung
            // 
            this.btnHitung.BackColor = System.Drawing.Color.Thistle;
            this.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHitung.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHitung.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnHitung.Location = new System.Drawing.Point(61, 314);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 5;
            this.btnHitung.Text = "Konversi";
            this.btnHitung.UseVisualStyleBackColor = false;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(58, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nilai";
            // 
            // txtNilai
            // 
            this.txtNilai.Location = new System.Drawing.Point(111, 98);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(182, 20);
            this.txtNilai.TabIndex = 9;
            this.txtNilai.TextChanged += new System.EventHandler(this.txtNilai_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(58, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hasil";
            // 
            // txtHasil
            // 
            this.txtHasil.BackColor = System.Drawing.Color.Thistle;
            this.txtHasil.Location = new System.Drawing.Point(111, 223);
            this.txtHasil.Multiline = true;
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.ReadOnly = true;
            this.txtHasil.Size = new System.Drawing.Size(182, 65);
            this.txtHasil.TabIndex = 11;
            this.txtHasil.TextChanged += new System.EventHandler(this.txtHasil_TextChanged);
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.Thistle;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnKeluar.Location = new System.Drawing.Point(218, 314);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 13;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Thistle;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnBatal.Location = new System.Drawing.Point(139, 314);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 373);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNilai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.cmbKe);
            this.Controls.Add(this.cmbDari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Aplikasi Konversi Massa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDari;
        private System.Windows.Forms.ComboBox cmbKe;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNilai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnBatal;
    }
}


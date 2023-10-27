namespace sarpras_dimasr
{
    partial class formSuplier
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
            this.barang = new System.Windows.Forms.DataGridView();
            this.tc = new System.Windows.Forms.TextBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.telponSuplier = new System.Windows.Forms.TextBox();
            this.idSuplier = new System.Windows.Forms.TextBox();
            this.namaSuplier = new System.Windows.Forms.TextBox();
            this.alamatSuplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barang)).BeginInit();
            this.SuspendLayout();
            // 
            // barang
            // 
            this.barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barang.Location = new System.Drawing.Point(485, 104);
            this.barang.Name = "barang";
            this.barang.RowTemplate.Height = 28;
            this.barang.Size = new System.Drawing.Size(483, 250);
            this.barang.TabIndex = 89;
            this.barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barang_CellClick);
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(625, 423);
            this.tc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(331, 26);
            this.tc.TabIndex = 87;
            this.tc.TextChanged += new System.EventHandler(this.tc_TextChanged);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(396, 393);
            this.btnKeluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(122, 58);
            this.btnKeluar.TabIndex = 86;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(276, 393);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 58);
            this.button3.TabIndex = 75;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 393);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 58);
            this.button2.TabIndex = 80;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 58);
            this.button1.TabIndex = 79;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "Alamat Suplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "Nama Suplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "ID Suplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 323);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 90;
            this.label3.Text = "Telp Suplier";
            // 
            // telponSuplier
            // 
            this.telponSuplier.Location = new System.Drawing.Point(157, 317);
            this.telponSuplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telponSuplier.Name = "telponSuplier";
            this.telponSuplier.Size = new System.Drawing.Size(296, 26);
            this.telponSuplier.TabIndex = 91;
            // 
            // idSuplier
            // 
            this.idSuplier.Location = new System.Drawing.Point(156, 98);
            this.idSuplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idSuplier.Name = "idSuplier";
            this.idSuplier.Size = new System.Drawing.Size(183, 26);
            this.idSuplier.TabIndex = 92;
            // 
            // namaSuplier
            // 
            this.namaSuplier.Location = new System.Drawing.Point(156, 141);
            this.namaSuplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.namaSuplier.Name = "namaSuplier";
            this.namaSuplier.Size = new System.Drawing.Size(296, 26);
            this.namaSuplier.TabIndex = 93;
            // 
            // alamatSuplier
            // 
            this.alamatSuplier.Location = new System.Drawing.Point(156, 178);
            this.alamatSuplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.alamatSuplier.Multiline = true;
            this.alamatSuplier.Name = "alamatSuplier";
            this.alamatSuplier.Size = new System.Drawing.Size(296, 129);
            this.alamatSuplier.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 425);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 95;
            this.label4.Text = "Cari";
            // 
            // formSuplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 520);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alamatSuplier);
            this.Controls.Add(this.namaSuplier);
            this.Controls.Add(this.idSuplier);
            this.Controls.Add(this.telponSuplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barang);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formSuplier";
            this.Text = "formSuplier";
            this.Load += new System.EventHandler(this.formSuplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView barang;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telponSuplier;
        private System.Windows.Forms.TextBox idSuplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namaSuplier;
        private System.Windows.Forms.TextBox alamatSuplier;
        private System.Windows.Forms.Label label4;
    }
}
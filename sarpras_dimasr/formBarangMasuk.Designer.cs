namespace sarpras_dimasr
{
    partial class formBarangMasuk
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namaBarang = new System.Windows.Forms.TextBox();
            this.jumlahBarang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.idBarang = new System.Windows.Forms.ComboBox();
            this.idSuplier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.barang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idbs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID Barang";
            // 
            // namaBarang
            // 
            this.namaBarang.Location = new System.Drawing.Point(182, 118);
            this.namaBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.Size = new System.Drawing.Size(296, 26);
            this.namaBarang.TabIndex = 28;
            // 
            // jumlahBarang
            // 
            this.jumlahBarang.Location = new System.Drawing.Point(182, 164);
            this.jumlahBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jumlahBarang.Name = "jumlahBarang";
            this.jumlahBarang.Size = new System.Drawing.Size(146, 26);
            this.jumlahBarang.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Jumlah Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tanggal Masuk";
            // 
            // tanggalMasuk
            // 
            this.tanggalMasuk.Location = new System.Drawing.Point(182, 203);
            this.tanggalMasuk.Name = "tanggalMasuk";
            this.tanggalMasuk.Size = new System.Drawing.Size(269, 26);
            this.tanggalMasuk.TabIndex = 46;
            // 
            // idBarang
            // 
            this.idBarang.FormattingEnabled = true;
            this.idBarang.Location = new System.Drawing.Point(182, 73);
            this.idBarang.Name = "idBarang";
            this.idBarang.Size = new System.Drawing.Size(121, 28);
            this.idBarang.TabIndex = 47;
            // 
            // idSuplier
            // 
            this.idSuplier.FormattingEnabled = true;
            this.idSuplier.Location = new System.Drawing.Point(182, 247);
            this.idSuplier.Name = "idSuplier";
            this.idSuplier.Size = new System.Drawing.Size(121, 28);
            this.idSuplier.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "ID Suplier";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 58);
            this.button1.TabIndex = 34;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(33, 28);
            this.tc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(262, 26);
            this.tc.TabIndex = 51;
            this.tc.TextChanged += new System.EventHandler(this.tc_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 315);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 58);
            this.button2.TabIndex = 35;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(291, 315);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 58);
            this.button3.TabIndex = 14;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(411, 315);
            this.btnKeluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(122, 58);
            this.btnKeluar.TabIndex = 50;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // barang
            // 
            this.barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barang.Location = new System.Drawing.Point(500, 26);
            this.barang.Name = "barang";
            this.barang.RowTemplate.Height = 28;
            this.barang.Size = new System.Drawing.Size(483, 250);
            this.barang.TabIndex = 53;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tc);
            this.groupBox1.Location = new System.Drawing.Point(606, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 69);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari";
            // 
            // idbs
            // 
            this.idbs.Location = new System.Drawing.Point(182, 39);
            this.idbs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idbs.Name = "idbs";
            this.idbs.Size = new System.Drawing.Size(146, 26);
            this.idbs.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Jumlah Barang";
            // 
            // formBarangMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 409);
            this.Controls.Add(this.idbs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barang);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idSuplier);
            this.Controls.Add(this.idBarang);
            this.Controls.Add(this.tanggalMasuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jumlahBarang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namaBarang);
            this.Name = "formBarangMasuk";
            this.Text = "formBarangMasuk";
            this.Load += new System.EventHandler(this.formBarangMasuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaBarang;
        private System.Windows.Forms.TextBox jumlahBarang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tanggalMasuk;
        private System.Windows.Forms.ComboBox idBarang;
        private System.Windows.Forms.ComboBox idSuplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.DataGridView barang;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idbs;
        private System.Windows.Forms.Label label5;
    }
}
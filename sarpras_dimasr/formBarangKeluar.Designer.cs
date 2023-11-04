namespace sarpras_dimasr
{
    partial class formBarangKeluar
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
            this.btnKeluar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idBarang = new System.Windows.Forms.ComboBox();
            this.tanggalKeluar = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.jumlahKeluar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namaBarang = new System.Windows.Forms.TextBox();
            this.lokasi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.penerima = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.barang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barang
            // 
            this.barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barang.Location = new System.Drawing.Point(494, 47);
            this.barang.Name = "barang";
            this.barang.RowTemplate.Height = 28;
            this.barang.Size = new System.Drawing.Size(483, 250);
            this.barang.TabIndex = 70;
            this.barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barang_CellClick);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(405, 336);
            this.btnKeluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(122, 58);
            this.btnKeluar.TabIndex = 67;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(285, 336);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 58);
            this.button3.TabIndex = 54;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 336);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 58);
            this.button2.TabIndex = 59;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 58);
            this.button1.TabIndex = 58;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idBarang
            // 
            this.idBarang.FormattingEnabled = true;
            this.idBarang.Location = new System.Drawing.Point(166, 33);
            this.idBarang.Name = "idBarang";
            this.idBarang.Size = new System.Drawing.Size(121, 28);
            this.idBarang.TabIndex = 64;
            this.idBarang.SelectedIndexChanged += new System.EventHandler(this.idBarang_SelectedIndexChanged);
            // 
            // tanggalKeluar
            // 
            this.tanggalKeluar.Location = new System.Drawing.Point(166, 163);
            this.tanggalKeluar.Name = "tanggalKeluar";
            this.tanggalKeluar.Size = new System.Drawing.Size(269, 26);
            this.tanggalKeluar.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Tanggal Keluar";
            // 
            // jumlahKeluar
            // 
            this.jumlahKeluar.Location = new System.Drawing.Point(166, 124);
            this.jumlahKeluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jumlahKeluar.Name = "jumlahKeluar";
            this.jumlahKeluar.Size = new System.Drawing.Size(146, 26);
            this.jumlahKeluar.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Jumlah Keluar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID Barang";
            // 
            // namaBarang
            // 
            this.namaBarang.Location = new System.Drawing.Point(166, 78);
            this.namaBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.Size = new System.Drawing.Size(296, 26);
            this.namaBarang.TabIndex = 55;
            // 
            // lokasi
            // 
            this.lokasi.Location = new System.Drawing.Point(165, 198);
            this.lokasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lokasi.Name = "lokasi";
            this.lokasi.Size = new System.Drawing.Size(146, 26);
            this.lokasi.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "lokasi";
            // 
            // penerima
            // 
            this.penerima.Location = new System.Drawing.Point(166, 234);
            this.penerima.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.penerima.Name = "penerima";
            this.penerima.Size = new System.Drawing.Size(146, 26);
            this.penerima.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Penerima";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tc);
            this.groupBox1.Location = new System.Drawing.Point(608, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 69);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari";
            // 
            // formBarangKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.penerima);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lokasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.barang);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idBarang);
            this.Controls.Add(this.tanggalKeluar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jumlahKeluar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namaBarang);
            this.Name = "formBarangKeluar";
            this.Text = "formBarangKeluar";
            this.Load += new System.EventHandler(this.formBarangKeluar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView barang;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox idBarang;
        private System.Windows.Forms.DateTimePicker tanggalKeluar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jumlahKeluar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaBarang;
        private System.Windows.Forms.TextBox lokasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox penerima;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tc;
    }
}
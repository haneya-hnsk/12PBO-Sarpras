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
            this.button4 = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.TextBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbidb = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJmlbrg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tnb = new System.Windows.Forms.TextBox();
            this.lk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barang)).BeginInit();
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
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(865, 342);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 46);
            this.button4.TabIndex = 69;
            this.button4.Text = "Cari";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(595, 352);
            this.tc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(262, 26);
            this.tc.TabIndex = 68;
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
            // cmbidb
            // 
            this.cmbidb.FormattingEnabled = true;
            this.cmbidb.Location = new System.Drawing.Point(166, 33);
            this.cmbidb.Name = "cmbidb";
            this.cmbidb.Size = new System.Drawing.Size(121, 28);
            this.cmbidb.TabIndex = 64;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(166, 163);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(269, 26);
            this.date.TabIndex = 63;
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
            // txtJmlbrg
            // 
            this.txtJmlbrg.Location = new System.Drawing.Point(166, 124);
            this.txtJmlbrg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJmlbrg.Name = "txtJmlbrg";
            this.txtJmlbrg.Size = new System.Drawing.Size(146, 26);
            this.txtJmlbrg.TabIndex = 61;
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
            // tnb
            // 
            this.tnb.Location = new System.Drawing.Point(166, 78);
            this.tnb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tnb.Name = "tnb";
            this.tnb.Size = new System.Drawing.Size(296, 26);
            this.tnb.TabIndex = 55;
            // 
            // lk
            // 
            this.lk.Location = new System.Drawing.Point(165, 198);
            this.lk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lk.Name = "lk";
            this.lk.Size = new System.Drawing.Size(146, 26);
            this.lk.TabIndex = 72;
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
            // pn
            // 
            this.pn.Location = new System.Drawing.Point(166, 234);
            this.pn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(146, 26);
            this.pn.TabIndex = 74;
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
            // formBarangKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 425);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.barang);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbidb);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJmlbrg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tnb);
            this.Name = "formBarangKeluar";
            this.Text = "formBarangKeluar";
            ((System.ComponentModel.ISupportInitialize)(this.barang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView barang;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbidb;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJmlbrg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tnb;
        private System.Windows.Forms.TextBox lk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pn;
        private System.Windows.Forms.Label label6;
    }
}
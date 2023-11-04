namespace sarpras_dimasr
{
    partial class formMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinjamBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangMasukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangKeluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBarangToolStripMenuItem,
            this.pinjamBarangToolStripMenuItem,
            this.suplierToolStripMenuItem,
            this.barangMasukToolStripMenuItem,
            this.barangKeluarToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // dataBarangToolStripMenuItem
            // 
            this.dataBarangToolStripMenuItem.Name = "dataBarangToolStripMenuItem";
            this.dataBarangToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.dataBarangToolStripMenuItem.Text = "Data Barang";
            this.dataBarangToolStripMenuItem.Click += new System.EventHandler(this.dataBarangToolStripMenuItem_Click);
            // 
            // pinjamBarangToolStripMenuItem
            // 
            this.pinjamBarangToolStripMenuItem.Name = "pinjamBarangToolStripMenuItem";
            this.pinjamBarangToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.pinjamBarangToolStripMenuItem.Text = "Pinjam Barang";
            this.pinjamBarangToolStripMenuItem.Click += new System.EventHandler(this.pinjamBarangToolStripMenuItem_Click);
            // 
            // suplierToolStripMenuItem
            // 
            this.suplierToolStripMenuItem.Name = "suplierToolStripMenuItem";
            this.suplierToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.suplierToolStripMenuItem.Text = "Suplier";
            this.suplierToolStripMenuItem.Click += new System.EventHandler(this.suplierToolStripMenuItem_Click);
            // 
            // barangMasukToolStripMenuItem
            // 
            this.barangMasukToolStripMenuItem.Name = "barangMasukToolStripMenuItem";
            this.barangMasukToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.barangMasukToolStripMenuItem.Text = "Barang Masuk ";
            this.barangMasukToolStripMenuItem.Click += new System.EventHandler(this.barangMasukToolStripMenuItem_Click);
            // 
            // barangKeluarToolStripMenuItem
            // 
            this.barangKeluarToolStripMenuItem.Name = "barangKeluarToolStripMenuItem";
            this.barangKeluarToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.barangKeluarToolStripMenuItem.Text = "Barang Keluar";
            this.barangKeluarToolStripMenuItem.Click += new System.EventHandler(this.barangKeluarToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 696);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMenu";
            this.Text = "formMenu";
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinjamBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangMasukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangKeluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
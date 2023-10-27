using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace sarpras_dimasr
{
    public partial class formBarangKeluar : Form
    {
        public formBarangKeluar()
        {
            InitializeComponent();
        }
        classKoneksi koneksi = new classKoneksi();
        public void tampildata()
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM barang_keluar", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;

        }
        private void formBarang_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("insert into  barang_keluar values (@id, @nb, @jb, @date, @lks)", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(cmbidb.Text));
            cmd.Parameters.AddWithValue("@nb", tnb.Text);
            cmd.Parameters.AddWithValue("@date", date.Value);
            cmd.Parameters.AddWithValue("@jb", txtJmlbrg.Text);
            cmd.Parameters.AddWithValue("@lks", lk.Text);
            cmd.Parameters.AddWithValue("@pn", pn.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Barang berhasil Disimpan");
            tampildata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("insert into  barang_keluar values (@id, @nb, @jb, @date, @lks)", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(cmbidb.Text));
            cmd.Parameters.AddWithValue("@nb", tnb.Text);
            cmd.Parameters.AddWithValue("@date", date.Value);
            cmd.Parameters.AddWithValue("@jb", txtJmlbrg.Text);
            cmd.Parameters.AddWithValue("@lks", lk.Text);
            cmd.Parameters.AddWithValue("@pn", pn.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Barang berhasil Disimpan");
            tampildata();
        }
    }
}

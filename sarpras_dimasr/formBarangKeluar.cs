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
            cmd.Parameters.AddWithValue("@id", int.Parse(idBarang.Text));
            cmd.Parameters.AddWithValue("@nb", namaBarang.Text);
            cmd.Parameters.AddWithValue("@date", tanggalKeluar.Value);
            cmd.Parameters.AddWithValue("@jb", jumlahKeluar.Text);
            cmd.Parameters.AddWithValue("@lks", lokasi.Text);
            cmd.Parameters.AddWithValue("@pn", penerima.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Barang berhasil Disimpan");
            tampildata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("insert into  barang_keluar values (@id, @nb, @jb, @date, @lks)", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(idBarang.Text));
            cmd.Parameters.AddWithValue("@nb", namaBarang.Text);
            cmd.Parameters.AddWithValue("@date", tanggalKeluar.Value);
            cmd.Parameters.AddWithValue("@jb", jumlahKeluar.Text);
            cmd.Parameters.AddWithValue("@lks", lokasi.Text);
            cmd.Parameters.AddWithValue("@pn", penerima.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Barang berhasil Disimpan");
            tampildata();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tc_TextChanged(object sender, EventArgs e)
        {
            if (tc.Text != "")
            {
                MySqlConnection conn = koneksi.mysqlkoneksi();
                MySqlCommand cmd = new MySqlCommand("select from barang_keluar where id_bk like @cari or id_barang like @cari or nama_barang like @cari ", conn);

                cmd.Parameters.AddWithValue("@cari", "%" + tc.Text + "%");

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data  berhasil Dihapus");
                tampildata();
            }
            else { tampildata(); }
        }

        private void formBarangKeluar_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        private void barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = barang.Rows[e.RowIndex];
            idBarang.Text = row.Cells[0].ToString();
            namaBarang.Text = row.Cells[1].ToString();
            jumlahKeluar.Text = row.Cells[2].ToString();
            tanggalKeluar.Value = Convert.ToDateTime(row.Cells[3].ToString());
            lokasi.Text = row.Cells[4].ToString();
            penerima.Text = row.Cells[5].ToString();
                    
        }
    }
}

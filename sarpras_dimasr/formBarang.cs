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
    public partial class formBarang : Form
    {
        public formBarang()
        {
            InitializeComponent();
        }



        classKoneksi koneksi = new classKoneksi();

        public void tampildata()
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM barang", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;

        }
        private void formBarang_Load(object sender, EventArgs e)
        {
            tampildata();
        }



        private void barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = barang.Rows[e.RowIndex];
            idBarang.Text = row.Cells[0].Value.ToString();
            namabarang.Text = row.Cells[1].Value.ToString();
            spesifikai.Text = row.Cells[2].Value.ToString();
            lokasi.Text = row.Cells[3].Value.ToString();
            kondisi.Text = row.Cells[4].Value.ToString();
            jumlahBarang.Text = row.Cells[5].Value.ToString();
            sumberDana.Text = row.Cells[6].Value.ToString();
        }



        private void Tambah_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("insert into  barang values (@idbarang, @namabarang, @spesifikasi, @lokasi, @kondisi, @jumlahbarang, @sumberdana)", conn);
            cmd.Parameters.AddWithValue("@idbarang", int.Parse(idBarang.Text));
            cmd.Parameters.AddWithValue("@namabarang", namabarang.Text);
            cmd.Parameters.AddWithValue("@spesifikasi", spesifikai.Text);
            cmd.Parameters.AddWithValue("@lokasi", lokasi.Text);
            cmd.Parameters.AddWithValue("@kondisi", kondisi.Text);
            cmd.Parameters.AddWithValue("@jumlahbarang", jumlahBarang.Text);
            cmd.Parameters.AddWithValue("@sumberdana", sumberDana.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Barang berhasil Disimpan");
            tampildata();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("update barang set nama_barang=@namabarang, spesifikasi=@spesifikasi, lokasi=@lokasi, kondisi=@kondisi, jumlah_barang=@jumlahbarang, sumber_dana=@sumberdana where id_barang=@idbarang", conn);
            cmd.Parameters.AddWithValue("@idbarang", int.Parse(idBarang.Text));
            cmd.Parameters.AddWithValue("@namabarang", namabarang.Text);
            cmd.Parameters.AddWithValue("@spesifikasi", spesifikai.Text);
            cmd.Parameters.AddWithValue("@lokasi", lokasi.Text);
            cmd.Parameters.AddWithValue("@kondisi", kondisi.Text);
            cmd.Parameters.AddWithValue("@jumlahbarang", jumlahBarang.Text);
            cmd.Parameters.AddWithValue("@sumberdana", sumberDana.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil Diubah");
            tampildata();
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM barang Where id_barang=@idbarang", conn);
            cmd.Parameters.AddWithValue("@idbarang", int.Parse(idBarang.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil dihapus");
            tampildata();
        }

        private void Keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM barang where id like @cari or nama_barang like @cari", conn);
            cmd.Parameters.AddWithValue("@cari", cari.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;
        }
    }
}

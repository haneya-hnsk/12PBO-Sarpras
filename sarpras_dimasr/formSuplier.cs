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
    public partial class formSuplier : Form
    {
        public formSuplier()
        {
            InitializeComponent();
        }
        classKoneksi koneksi = new classKoneksi();

        public void tampildata()
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM suplier", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("insert into suplier values(@id, @nama, @alamat, @telpon)", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(idSuplier.Text));
            cmd.Parameters.AddWithValue("@nama", namaSuplier.Text);
            cmd.Parameters.AddWithValue("@alamat", alamatSuplier.Text);
            cmd.Parameters.AddWithValue("@telpon", telponSuplier.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data  berhasil Diubah");
            tampildata();
        }

        private void formSuplier_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("update suplier set nama_suplier = @nama, alamat_suplier = @alamat, telp_suplier = @telpon where id_suplier = @id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(idSuplier.Text));
            cmd.Parameters.AddWithValue("@nama", namaSuplier.Text);
            cmd.Parameters.AddWithValue("@alamat", alamatSuplier.Text);
            cmd.Parameters.AddWithValue("@telpon", telponSuplier.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data  berhasil Diubah");
            tampildata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("delete from suplier where id_suplier=@idbs", conn);

            cmd.Parameters.AddWithValue("@idbs", idSuplier.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data  berhasil Dihapus");
            tampildata();
        }

        private void tc_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM suplier where id_suplier like @id or nama_suplier like @nama", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(idSuplier.Text));
            cmd.Parameters.AddWithValue("@nama", namaSuplier.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;

        }

        private void barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = barang.Rows[e.RowIndex];
            idSuplier.Text = row.Cells[0].Value.ToString();
            namaSuplier.Text = row.Cells[1].Value.ToString();
            alamatSuplier.Text = row.Cells[2].Value.ToString();
            telponSuplier.Text = row.Cells[3].Value.ToString();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

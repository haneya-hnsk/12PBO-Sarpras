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


            MySqlCommand cmd2 = new MySqlCommand("SELECT id_barang FROM barang", conn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                idBarang.Items.Add(dt2.Rows[i]["id_barang"].ToString());
            }

        }
        private void formBarang_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("insert into  barang_keluar values (@id, @nb,  @date,@jb, @lks, @pn)", conn);
            cmd.Parameters.AddWithValue("@id", idBarang.Text);
            cmd.Parameters.AddWithValue("@nb", namaBarang.Text);
            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(tanggalKeluar.Value));
            cmd.Parameters.AddWithValue("@jb", jumlahKeluar.Text);
            cmd.Parameters.AddWithValue("@lks", lokasi.Text);
            cmd.Parameters.AddWithValue("@pn", penerima.Text);
            cmd.ExecuteNonQuery();

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM barang Where id_barang=@id", conn);
            cmd1.Parameters.AddWithValue("@id", idBarang.Text);

            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                int database = Convert.ToInt32(dt1.Rows[0]["jumlah_barang"]); 
                int lokal = Convert.ToInt32(jumlahKeluar.Text);

                int total = database - lokal;
                MySqlCommand cmd2 = new MySqlCommand("update barang set jumlah_barang = @total where id_barang = @id ", conn);

                cmd2.Parameters.AddWithValue("@id", idBarang.Text);
                cmd2.Parameters.AddWithValue("@total", total);
                cmd2.ExecuteNonQuery();



            }
            MessageBox.Show("Data Barang berhasil Disimpan");
                tampildata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("update barang_keluar set id_barang=@id, nama_barang=@nb, tgl_keluar=@date, jml_keluar=@jk, lokasi=@lks, penerima=@pn where id_bk=@idbk", conn);
            cmd.Parameters.AddWithValue("@idbk", idbk.Text);
            cmd.Parameters.AddWithValue("@id", idBarang.Text);
            cmd.Parameters.AddWithValue("@nb", namaBarang.Text);
            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(tanggalKeluar.Value));
            cmd.Parameters.AddWithValue("@jk", jumlahKeluar.Text);
            cmd.Parameters.AddWithValue("@lks", lokasi.Text);
            cmd.Parameters.AddWithValue("@pn", penerima.Text); ;
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
            idBarang.Text = row.Cells[0].Value.ToString();
            namaBarang.Text = row.Cells[1].Value.ToString();
            jumlahKeluar.Text = row.Cells[3].Value.ToString();
            tanggalKeluar.Value = Convert.ToDateTime(row.Cells[2].Value);
            lokasi.Text = row.Cells[4].Value.ToString();
            penerima.Text = row.Cells[5].Value.ToString();
            idbk.Text = row.Cells[6].Value.ToString();

        }

        private void idBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idBarang.SelectedIndex >= 0)
            {

                MySqlConnection conn = koneksi.mysqlkoneksi();
                MySqlCommand cmd = new MySqlCommand("SELECT * from barang where id_barang = @nama", conn);
                cmd.Parameters.AddWithValue("@nama", idBarang.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                namaBarang.Text = dt.Rows[0]["nama_barang"].ToString();
            }
            else { }
        }

        private void idbm_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("delete from barang_keluar where id_bk=@idbk", conn);
            cmd.Parameters.AddWithValue("@idbk", idbk.Text);
           
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Barang berhasil Disimpan");
            tampildata();
        }
    }
}

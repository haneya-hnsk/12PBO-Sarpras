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
    public partial class formBarangMasuk : Form
    {
        public formBarangMasuk()
        {
            InitializeComponent();
        }       
        classKoneksi koneksi = new classKoneksi();

        public void addItems() {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT id_suplier from suplier", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++) idSuplier.Items.Add(dt.Rows[i]["id_suplier"]);

            MySqlCommand cmd2 = new MySqlCommand("SELECT id_barang from barang", conn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            for (int i = 0; i < dt2.Rows.Count; i++) idBarang.Items.Add(dt2.Rows[i]["id_barang"]);

        }
        public void tampildata()
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM barang_masuk", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("insert into  barang_masuk values (@idbm,@id, @nb, @jb, @date, @ids)", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(idBarang.Text));
            cmd.Parameters.AddWithValue("@nb", namaBarang.Text);
            cmd.Parameters.AddWithValue("@idbm", idbm.Text);
            cmd.Parameters.AddWithValue("@jb", jumlahBarang.Text);
            cmd.Parameters.AddWithValue("@date", tanggalMasuk.Value);
            cmd.Parameters.AddWithValue("@ids", idSuplier.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Barang berhasil Disimpan");
            tampildata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("update set id_barang=@id nama_barang=@nb, jumlah_barang=@jb, tanggal_masuk=@date, id_suplier=@ids where id_bm=@idbm ", conn);

            cmd.Parameters.AddWithValue("@id", int.Parse(idBarang.Text));
            cmd.Parameters.AddWithValue("@nb", namaBarang.Text);
            cmd.Parameters.AddWithValue("@idbm", idbm.Text);
            cmd.Parameters.AddWithValue("@jb", jumlahBarang.Text);
            cmd.Parameters.AddWithValue("@date", tanggalMasuk.Value);
            cmd.Parameters.AddWithValue("@ids", idSuplier.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data  berhasil Diubah");
            tampildata();

           

        }

       public void stokdata() {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM stok", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("delete from barang_masuk where id_bs=@idbs", conn);
          
            cmd.Parameters.AddWithValue("@idbs", idbm.Text);
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data  berhasil Dihapus");
            tampildata();
        }

        private void formBarangMasuk_Load(object sender, EventArgs e)
        {
            tampildata();
            addItems();
        }

        private void tc_TextChanged(object sender, EventArgs e)
        {
            if(tc.Text != "") {
                MySqlConnection conn = koneksi.mysqlkoneksi();
                MySqlCommand cmd = new MySqlCommand("select from barang_masuk where id_bs like @cari or id_barang like @cari or nama_barang like @cari ", conn);

                cmd.Parameters.AddWithValue("@cari", "%"  + tc.Text + "%");

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data  berhasil Dihapus");
                tampildata();
            }
            else { tampildata(); }
        }

        private void barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = barang.Rows[e.RowIndex];
            idbm.Text = row.Cells[0].ToString();
            idBarang.Text = row.Cells[1].ToString();
            namaBarang.Text = row.Cells[2].ToString();
            jumlahBarang.Text = row.Cells[4].ToString();
            tanggalMasuk.Value = Convert.ToDateTime(row.Cells[3]);
            
            idSuplier.Text = row.Cells[5].ToString();
        }
    }
}

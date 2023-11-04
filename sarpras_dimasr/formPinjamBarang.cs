using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace sarpras_dimasr
{
    public partial class formPinjamBarang : Form
    {
        public formPinjamBarang()
        {
            InitializeComponent();
        }

        public void tampildata()
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM pinjam_barang", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            barang.DataSource = dt;


            MySqlCommand cmd2 = new MySqlCommand("SELECT id_barang FROM barang", conn);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
           
            for (int i = 0; i<dt2.Rows.Count; i++) {
                idBarang.Items.Add(dt2.Rows[i]["id_barang"].ToString());
            }
            
        }

        private void Clear()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);

                foreach (Control control in controls)
                    if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        classKoneksi koneksi = new classKoneksi();

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("insert into pinjam_barang values (@id,@peminjam, @tglpinjam, @idb, @namabrg, @jmlbrg, @tglkembali, @kondisi )", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(idPinjam.Text));
            cmd.Parameters.AddWithValue("@peminjam", peminjam.Text);
            cmd.Parameters.AddWithValue("@tglPinjam", Convert.ToDateTime(tanggalPinjam.Value));
            cmd.Parameters.AddWithValue("@tglKembali", Convert.ToDateTime(tanggalKembali.Value));
            cmd.Parameters.AddWithValue("@jmlbrg", jumlahBarang.Text);
            cmd.Parameters.AddWithValue("@namabrg", idBarang.Text);
            cmd.Parameters.AddWithValue("@kondisi", kondisi.Text);
            cmd.Parameters.AddWithValue("@idb", namaBarang.Text);
                cmd.ExecuteNonQuery();
            MessageBox.Show("Data Barang berhasil Disimpan");
            tampildata();
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("update pinjam_barang set peminjam=@peminjam, tgl_pinjam=@tglpinjam, tgl_kembali=@tglkembali, kondisi=@kondisi, id_barang=@idb, nama_barang=@namabrg where id_pinjam=@id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(idPinjam.Text));
            cmd.Parameters.AddWithValue("@peminjam", peminjam.Text);
            cmd.Parameters.AddWithValue("@tglPinjam", Convert.ToDateTime(tanggalPinjam.Value));
            cmd.Parameters.AddWithValue("@tglKembali", Convert.ToDateTime(tanggalKembali.Value));
            cmd.Parameters.AddWithValue("@jmlbrg", jumlahBarang.Text);
            cmd.Parameters.AddWithValue("@namabrg", idBarang.Text);
            cmd.Parameters.AddWithValue("@kondisi", kondisi.Text);
            cmd.Parameters.AddWithValue("@idb", namaBarang.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Barang berhasil Disimpan");
            tampildata();
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.mysqlkoneksi();
            MySqlCommand cmd = new MySqlCommand("delete from pinjam_barang where id_pinjam=@id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(idPinjam.Text));
           
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Barang berhasil Disimpan");
            tampildata();
            Clear();
        }

        private void formPinjamBarang_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            if(cari.Text != "") {
                MySqlConnection conn = koneksi.mysqlkoneksi();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM pinjam_barang where id_pinjam like @cari or nama_barang like @cari or peminjam like @cari", conn);
                cmd.Parameters.AddWithValue("@cari", "%" + cari.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                barang.DataSource = dt;
            }
            else { tampildata(); }


        }



        private void barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = barang.Rows[e.RowIndex];
            idPinjam.Text = Row.Cells[0].Value.ToString();
            peminjam.Text = Row.Cells[1].Value.ToString();

            tanggalPinjam.Value = Convert.ToDateTime(Row.Cells[2].Value);
            namaBarang.Text = Row.Cells[4].Value.ToString();
            idBarang.Text = Row.Cells[3].Value.ToString();
            jumlahBarang.Text = Row.Cells[5].Value.ToString();
            tanggalKembali.Value = Convert.ToDateTime(Row.Cells[6].Value);
            kondisi.Text = Row.Cells[7].Value.ToString();
        }

        private void namaBarang_SelectedIndexChanged(object sender, EventArgs e)
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

     
    }
}

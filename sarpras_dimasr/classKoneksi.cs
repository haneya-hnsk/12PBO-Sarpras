using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sarpras_dimasr
{
    class classKoneksi
    {
    public MySqlConnection mysqlkoneksi() {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=db_sarpras_dimasr;Uid=root;Pwd=;");
            conn.Open();
            return conn;
    }
    }
}

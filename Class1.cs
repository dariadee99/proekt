using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace УчебнаяПрактика1
{
    class Class1
    {
        public bool autoriz(string Login, string Password, int id_dolzhnost)
        {
            bool check = false;

            string DataSource = @"Data Source=LAPTOP-MHMT7HOQ\SQLEXPRESS;Initial Catalog=Учёт;Integrated Security=True";
            SqlConnection conn = new SqlConnection(DataSource);
            string command = "SELECT Login, Password, id_dolzhnost FROM [Sotrydnik] WHERE Login = '" + Login + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToString(reader[0]) == Login && Convert.ToString(reader[1]) == Password
                    && Convert.ToInt32(reader[2]) == id_dolzhnost)
                {
                    check = true;
                    break;
                }
            }
            conn.Close();
            return check;
        }
    }
}

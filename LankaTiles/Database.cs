using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LankaTiles
{
    class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;


        public Database()
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-PLMQAVR\\SQLEXPRESS;Initial Catalog=LankaTiles2;Integrated Security=True");

            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to Database!");
               
            }

        }
        public String getValue(String query)
        {
            String foundValue = "";
            using (con)
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foundValue = reader[0].ToString();
                        }
                    }
                }
            }
            con.Close();
            return foundValue;
        }

        public void inserUpdateDelete(String query)
        {
            con.ConnectionString = "Data Source=DESKTOP-PLMQAVR\\SQLEXPRESS;Initial Catalog=LankaTiles2;Integrated Security=True";
            con.Open();
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            try
            {
               
            }
            catch (Exception)
            {
                MessageBox.Show("Database Error :(");                
            }
        }

        public DataTable select(String query)
        {
            con.Open();
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }
}

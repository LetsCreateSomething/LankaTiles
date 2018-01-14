using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace LankaTiles
{
    class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private string strConn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public Database()
        {
            try
            {
                //  con = new SqlConnection("Data Source=DESKTOP-PLMQAVR\\SQLEXPRESS;Initial Catalog=LankaTiles2;Integrated Security=True");
                con = new SqlConnection(strConn);
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
            // con.ConnectionString = "Data Source=DESKTOP-PLMQAVR\\SQLEXPRESS;Initial Catalog=LankaTiles2;Integrated Security=True";
            con.ConnectionString = strConn;
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

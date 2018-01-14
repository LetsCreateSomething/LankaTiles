using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LankaTiles
{
    public partial class Form1 : Form
    {

        public static String pass;
        public static bool loggeduserStatus;
        //  String Value;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            Database db = new Database();

            dt = db.select("select * from users where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'");
            loggeduserStatus = true;

            if (dt.Rows.Count == 1)
            {
                //MessageBox.Show(this, "Logged in Success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                pass = txtUsername.Text;
                string a = "insert into LoginAudit (userName,loginTime) values('" + Form1.pass + "','" + DateTime.Now + "')";
                db.inserUpdateDelete(a);
               
                Home home = new Home();
                home.Show();
            }
            else
                MessageBox.Show(this, "Username or Password is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact company IT Manager for creating new accounts!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

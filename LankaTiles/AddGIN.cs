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
    public partial class AddGIN : Form
    {
        public DataTable dt,dt1,dt2,dt3;
        public AddGIN()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtDescription.Clear();
            txtQty.Clear();
            txtPrice.Clear();
        }

        private void AddGIN_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            db.inserUpdateDelete("delete from GINTemp");
            lblDate.Text = DateTime.Today.ToString("d");
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            txtDiscounts.Text = null;
        }

        private void txtDiscounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        public void txtDiscounts_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDiscounts.Text))
                {
                    txtNetValue.Text = (Convert.ToDouble(txtDiscounts.Text) * Convert.ToDouble(dt1.Rows[0][0])).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter discounts like 0.(value)!");                
            }
        }

        private void txtTotalValue_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                txtDiscounts.Enabled = true;
            }
            else
            {
                txtDiscounts.Enabled = false;                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure!", "Warning!",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Database db = new Database();
                db.inserUpdateDelete("delete from AddGINTemp");
                lblDate.Text = DateTime.Today.ToString("d");
                lblTime.Text = DateTime.Now.ToString("HH:mm");
                dataGridView1.DataSource = null;
                txtTotalValue.Clear();
                txtDiscounts.Clear();
                txtNetValue.Clear();
                this.btnClear_Click(sender, e);
            }
        }

        private void btnGenerateGIN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)||string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Empty Areas! Please fill.");
            }
            else
            {
                Database db = new Database();
                string query1 = "insert into GIN (name, invoice, address, date, time, totalValue, discounts, netValue) values ('" + txtName.Text + "','" + cmbInvoice.SelectedIndex + "','" + txtAddress.Text + "','" + lblDate.Text + "','" + lblTime.Text + "','" + txtTotalValue.Text + "','" + txtDiscounts.Text + "','" + txtNetValue.Text + "')";
                db.inserUpdateDelete(query1);
                dt2 = db.select("select GINID from GIN where name = '" + txtName.Text + "'");
                string id = dt2.Rows[0][0].ToString();
                string query2 = "create table GIN" + id + " (GINID int , code varchar(100), description varchar(300), qty float , price float, value float)";
                db.inserUpdateDelete(query2);
                dt3 = db.select("select * from AddGINTemp");
                for (int i = 0; dt3.Rows.Count > i; i++)
                {
                    //insert Query
                    db.inserUpdateDelete("insert into GIN" + id + " values ( '" + id + "', '" + dt3.Rows[i].ItemArray.GetValue(0).ToString() + "', '" + dt3.Rows[i].ItemArray.GetValue(1).ToString() + "', '" + dt3.Rows[i].ItemArray.GetValue(2).ToString() + "','" + dt3.Rows[i].ItemArray.GetValue(3).ToString() + "','" + dt3.Rows[i].ItemArray.GetValue(4).ToString() + "')");
                    MessageBox.Show("GIN added successfully!");
                    this.Close();
                }
            } 
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtQty.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Empty areas. Please fill all fields!");
            }
            else if (!txtQty.Text.Any(Char.IsDigit)||!txtPrice.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("Quantity or Price is not valid!");
                txtPrice.Clear();
                txtQty.Clear();
            }
            else
            {
                Database db = new Database();
                string query = "insert into AddGINTemp values ('" + txtCode.Text + "','" + txtDescription.Text + "','" + txtQty.Text + "','" + txtPrice.Text + "','" + (Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtPrice.Text)).ToString() + "')";
                db.inserUpdateDelete(query);                
                dt = db.select("select * from AddGINTemp");
                dataGridView1.DataSource = dt;

                //Change datagridview column Header Names
                dataGridView1.Columns[0].HeaderText = "Code";
                dataGridView1.Columns[1].HeaderText = "Description";
                dataGridView1.Columns[2].HeaderText = "Quantity";
                dataGridView1.Columns[3].HeaderText = "Price";
                dataGridView1.Columns[4].HeaderText = "Value";

                txtCode.Clear();
                txtDescription.Clear();
                txtPrice.Clear();               
                txtQty.Clear();
                try
                {
                    dt1 = db.select("select sum(value) from AddGINTemp");
                    txtTotalValue.Text = dt1.Rows[0][0].ToString();
                    txtDiscounts.Clear();
                    txtNetValue.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong with the database!");                    
                }
                txtNetValue.Text = txtTotalValue.Text;

            }
        }
    }
}

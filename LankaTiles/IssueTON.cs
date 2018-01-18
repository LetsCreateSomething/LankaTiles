using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LankaTiles
{
    public partial class IssueTON : Form
    {
        DataTable dt, dt1, dt2;
        TransferOutNote ton;
        Database db,db1;

        public IssueTON()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbItemCode.Text = "";
            txtItemName.Text = "";
            txtQty.Clear();
            txtUnitPrice.Clear();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            db = new Database();
            if (string.IsNullOrEmpty(cmbItemCode.Text) || string.IsNullOrEmpty(txtQty.Text) || string.IsNullOrEmpty(txtUnitPrice.Text))
            {
                MessageBox.Show("Empty Fields!");
            }
            else if (!txtQty.Text.Any(char.IsDigit) || !txtUnitPrice.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Quantity and Price is not valid!");
            }
            else
            {
                dt = db.select("select qty from item where itemID = " + cmbItemCode.SelectedValue + "");
                if (Convert.ToInt32(dt.Rows[0][0].ToString()) < Convert.ToInt32(txtQty.Text))
                {
                    MessageBox.Show("Not enough quantity in stock!! \nOnly " + dt.Rows[0][0].ToString() + " pcs available.");
                }
                else
                {
                    dt = db.select("select * from tonTemp");
                    int mark = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.Field<int>(1) == Convert.ToInt32(cmbItemCode.SelectedValue))
                        {
                            mark = 1;
                            break;
                        }
                    }

                    if (mark == 1)
                    {
                        string updateQuery = "update tonTemp set qty = qty+" + txtQty.Text + " where itemID = " + cmbItemCode.SelectedValue + "";
                        //MessageBox.Show(updateQuery);
                        db.inserUpdateDelete(updateQuery);
                    }
                    else
                    {
                        string queryTemp = " insert into tonTemp values (" + txtTONNo.Text + " ," + cmbItemCode.SelectedValue + ",'" + txtItemName.Text + "'," + txtQty.Text + "," + txtUnitPrice.Text + ")";
                        //MessageBox.Show(queryTemp);
                        db.inserUpdateDelete(queryTemp);
                    }
                    dt = new DataTable();
                    dt = db.select("select TONID as ID, itemId as [Item ID], itemName as [Item Name], qty as Quantity, unitPrice as [Unit Price] from tonTemp");
                    dataGridView1.DataSource = dt;
                    btnDelete.Enabled = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedTONId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            DialogResult dr = MessageBox.Show("Are you sure want to delete?", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                db = new Database();
                db.inserUpdateDelete("delete from tonTemp where itemID = " + selectedTONId + "");
                dt = new DataTable();
                dt = db.select("select * from tonTemp");
                dataGridView1.DataSource = dt;
            }
        }

        private void cmbItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new Database();
            dt = new DataTable();
            dt  = db.select("select itemName,unitprice from item where itemID = '" + cmbItemCode.SelectedValue + "'");
            txtItemName.Text = dt.Rows[0][0].ToString();
            txtUnitPrice.Text = dt.Rows[0][1].ToString();            
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            ton = new TransferOutNote();
            ton.FromLocation = txtFromLocation.Text;
            ton.Destination = cmbDestination.Text;
            ton.Id = Convert.ToInt32(txtTONNo.Text);
            ton.addTON();           
            MessageBox.Show("TON added successfully!");
            this.Close();
        }                      

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IssueTON_Load(object sender, EventArgs e)
        {
            ton = new TransferOutNote();

            //Get Date
            txtDate.Text = DateTime.Now.ToString();
            db = new Database();
            db.inserUpdateDelete("delete from tonTemp");
            //Get TON ID
            string id;
            id = ton.getMaxId();
            if (string.IsNullOrEmpty(id))
            {
                txtTONNo.Text = "1";
            }
            else
            {
                txtTONNo.Text = (Convert.ToInt32(id) + 1).ToString();
            }            
            db1 = new Database();
            //Fill Combo 
            Item item = new Item();
            dt1 = item.getItemDetails();                       
            
            cmbItemCode.ValueMember = "itemID";
            cmbItemCode.DisplayMember = "itemCode";
            cmbItemCode.DataSource = dt1;

            dt2 = db1.select("select * from warehouses");

            cmbDestination.DataSource = dt2;
            cmbDestination.ValueMember = "location";
        }
    }
}

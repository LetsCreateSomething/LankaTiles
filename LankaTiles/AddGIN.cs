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
        private void AddGIN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lankaTiles2DataSet1.invoice' table. You can move, or remove it, as needed.
  //          this.invoiceTableAdapter1.Fill(this.lankaTiles2DataSet1.invoice);
            // TODO: This line of code loads data into the 'lankaTiles2DataSet.invoice' table. You can move, or remove it, as needed.
           // this.invoiceTableAdapter.Fill(this.lankaTiles2DataSet.invoice);
            Invoice invoice = new Invoice();
            GoodIssueNote gin = new GoodIssueNote();
            dt = invoice.getInvoiceforGIN();          
            string GINID = gin.getMaxGINID();
            if (string.IsNullOrEmpty(GINID))
            {
                txtGINID.Text = "1";
            }
            else
            {
                txtGINID.Text =(Convert.ToInt16(GINID)+1).ToString();
            }           
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
            cmbInvoice.DataSource = dt;
            cmbInvoice.ValueMember = "invID";
            gin.dropTemp();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
             int selectedItemId;
            if (dataGridView2.CurrentRow != null)
            {
                selectedItemId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
                // int selectedItemQty = Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value);

                // MessageBox.Show(selectedItemId.ToString());
                Item item = new Item();
                string rfid;
                rfid = item.getItemRfid(selectedItemId);
                RFID Rfid = new RFID();
                bool mark;
                mark = Rfid.verify(rfid);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==3)
            {
                Invoice invoice = new Invoice();
                try
                {
                    int selectedInvId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    int selectedItemID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
                    int selectedQty = Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value);
                    bool isChecked = (bool)dataGridView2.CurrentRow.Cells[3].Value;
                    if (isChecked==false)
                    {
                        if (selectedInvId != null && selectedItemID != null)
                        {
                            invoice.updateInvoice(selectedInvId, selectedItemID,1);                         
                            GoodIssueNote gin = new GoodIssueNote();
                            gin.addGINTemp(txtGINID.Text,selectedItemID,selectedQty,selectedInvId);
                            dt3 = gin.getGINTemp();
                            dataGridView3.DataSource = dt3;
                        }
                    }
                    else
                    {
                        if (selectedInvId != null && selectedItemID != null)
                        {
                            invoice.updateInvoice(selectedInvId, selectedItemID, 0);                           
                            MessageBox.Show("updated as not Issued!");
                        }
                    }                    
                }
                catch (Exception)
                {
                }
            }
        }

        private void cmbInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            string id = cmbInvoice.Text;
            dt = invoice.getInvoice(Convert.ToInt16(id));
            dataGridView2.DataSource = dt;
            txtCustomer.Text = invoice.getCustomerName(id);
        }

        private void btnGenerateGIN_Click(object sender, EventArgs e)
        {
            GoodIssueNote gin = new GoodIssueNote();
            dt = gin.getGINTemp();
            if (dt.Rows.Count > 0)
            {
                gin.Customer = txtCustomer.Text;
                gin.Date = DateTime.Today.ToShortDateString();
                gin.ginID = txtGINID.Text;
                gin.addGIN();
                MessageBox.Show("GIN Added Successfully!");
                this.Close();
            }        
            else
            {
                MessageBox.Show("No items selected!");
            }
            
        }
    }
}

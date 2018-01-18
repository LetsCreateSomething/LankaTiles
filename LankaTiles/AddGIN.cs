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
        Invoice invoice;
        GoodIssueNote gin;
        Item item;
        RFID Rfid;
        string rfid;
        string GINID;
        bool isChecked;
        public AddGIN()
        {
            InitializeComponent();
        }      
        private void AddGIN_Load(object sender, EventArgs e)
        {           
            invoice = new Invoice();
            gin = new GoodIssueNote();
            dt = invoice.getInvoiceforGIN();          
            GINID = gin.getMaxGINID();

            if (string.IsNullOrEmpty(GINID))            
                txtGINID.Text = "1";            
            else            
                txtGINID.Text =(Convert.ToInt16(GINID)+1).ToString();                    

            txtDate.Text = DateTime.Now.ToShortDateString();           
                        
            cmbInvoice.ValueMember = "invID";
            cmbInvoice.DisplayMember = "InvID";
            cmbInvoice.DataSource = dt;

            gin.dropTemp();

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int selectedItemId;
            if (dataGridView2.CurrentRow != null)
            {
                selectedItemId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
                item = new Item();                
                rfid = item.getItemRfid(selectedItemId);
                Rfid = new RFID();
                bool mark;
                mark = Rfid.verify(rfid);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {


                if (e.ColumnIndex == 4)
                {
                    invoice = new Invoice();
                    int selectedInvId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                    int selectedItemID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[5].Value);
                    int selectedQty = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value);
                    isChecked = (bool)dataGridView2.CurrentRow.Cells[4].Value;

                    if (isChecked == false)
                    {
                        invoice.updateInvoice(selectedInvId, selectedItemID, 1);
                        gin = new GoodIssueNote();
                        gin.addGINTemp(txtGINID.Text, selectedItemID, selectedQty, selectedInvId);
                        dt3 = gin.getGINTemp();
                        dataGridView3.DataSource = dt3;
                    }
                    else
                    {
                        invoice.updateInvoice(selectedInvId, selectedItemID, 0);
                        gin = new GoodIssueNote();
                        gin.updateGINTemp(selectedItemID);
                        dt3 = gin.getGINTemp();
                        MessageBox.Show("updated as not Issued!");
                        dataGridView3.DataSource = dt3;
                    }                   
                }
            }
        }

        private void cmbInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            invoice = new Invoice();
            string id = cmbInvoice.Text;
            dt = invoice.getInvoice(Convert.ToInt16(id));
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[5].Visible = false;

            txtCustomer.Text = invoice.getCustomerName(id);
        }

        private void btnGenerateGIN_Click(object sender, EventArgs e)
        {
            gin = new GoodIssueNote();
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

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
    public partial class AddTIN : Form
    {
        DataTable dt, dt1;
        TransferInNote tin;
        public AddTIN()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                int selectedTINID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    tin = new TransferInNote();
                    //MessageBox.Show(selectedTINID.ToString());
                    dt1 = tin.getPendingTIN(selectedTINID);
                    dataGridView2.DataSource = dt1;               
            }
        }

        private void btnAddToTIN_Click(object sender, EventArgs e)
        {
            tin = new TransferInNote();
            if (dataGridView1.CurrentRow!=null)
            {
                int selectedToNID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                tin.addTIN(selectedToNID);
                MessageBox.Show("TIN Added!");
                dt = tin.getPendingTIN();
                dataGridView2.DataSource = null;
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 150;
            }            
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow!=null)
            {
                int selectedItemID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
                Item item = new Item();
                string rfid;
                rfid = item.getItemRfid(selectedItemID);
                RFID Rfid = new RFID();
                bool mark;
                mark = Rfid.verify(rfid);
            }            
        }

        private void AddTIN_Load(object sender, EventArgs e)
        {
            tin = new TransferInNote();            
            dt = tin.getPendingTIN();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
        }
    }
}

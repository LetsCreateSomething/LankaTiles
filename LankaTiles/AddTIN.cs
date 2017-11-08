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
        public DataTable dt, dt1;
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
            try
            {
                int selectedTINID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (selectedTINID != null)
                {
                    TransferInNote tin = new TransferInNote();
                    //MessageBox.Show(selectedTINID.ToString());
                    dt1 = tin.getPendingTIN(selectedTINID);
                    dataGridView2.DataSource = dt1;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnAddToTIN_Click(object sender, EventArgs e)
        {
            TransferInNote tin = new TransferInNote();
            try
            {
                int selectedToNID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (selectedToNID!=null)
                {
                    tin.addTIN(selectedToNID);
                    MessageBox.Show("TIN Added!");
                    dt = tin.getPendingTIN();
                    dataGridView2.DataSource = null;
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[4].Visible = false;
                }
               
            }
            catch (Exception)
            {               
            }
           
        }

        private void AddTIN_Load(object sender, EventArgs e)
        {
            TransferInNote tin = new TransferInNote();            
            dt = tin.getPendingTIN();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[4].Visible = false;

        }
    }
}

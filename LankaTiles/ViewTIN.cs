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
    public partial class ViewTIN : Form
    {
        DataTable dt;        
        public ViewTIN()
        {
            InitializeComponent();
        }

        private void ViewTIN_Load(object sender, EventArgs e)
        {
            TransferInNote tin = new TransferInNote();
            dt = tin.viewTIN();  
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedTINID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            TransferInNote tin = new TransferInNote();
            //MessageBox.Show(selectedTINID.ToString());
            dt = tin.searchTIN(selectedTINID);
            dataGridView2.DataSource = dt;            
        }
    }
}

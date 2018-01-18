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
    public partial class ViewTON : Form
    {
        DataTable dt, dt1;
        TransferOutNote ton;
        public ViewTON()
        {
            InitializeComponent();
        }     

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                TransferOutNote ton = new TransferOutNote();
                dt1 = ton.getTON(selectedId);
                dataGridView2.DataSource = dt1;
            }                                                    
        }

        private void ViewTON_Load(object sender, EventArgs e)
        {
            ton = new TransferOutNote();
            dt = ton.getTON();
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 50;
        }
    }
}

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
        public DataTable dt, dt1;
        public ViewTON()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (selectedId != null)
                {
                    TransferOutNote ton = new TransferOutNote();
                    dt1 = ton.getTON(selectedId);
                    dataGridView2.DataSource = dt1;
                }               
            }
            catch (Exception)
            {               
            }
        }

        private void ViewTON_Load(object sender, EventArgs e)
        {
            TransferOutNote ton = new TransferOutNote();
            dt = ton.getTON();
            dataGridView1.DataSource = dt;
        }
    }
}

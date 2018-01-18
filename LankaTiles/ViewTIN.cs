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
        TransferInNote tin;
        public ViewTIN()
        {
            InitializeComponent();
        }

        private void ViewTIN_Load(object sender, EventArgs e)
        {
            tin = new TransferInNote();
            dt = tin.viewTIN();  
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
        }    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow!=null)
                {
                    int selectedTINID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    tin = new TransferInNote();
                        //MessageBox.Show(selectedTINID.ToString());
                        dt = tin.searchTIN(selectedTINID);
                        dataGridView2.DataSource = dt;
                    
                }                
            }
            catch (Exception)
            {
            }                        
        }
    }
}

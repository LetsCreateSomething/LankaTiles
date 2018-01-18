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
    public partial class ManageGIN : Form
    {
        DataTable dt, dt1;
        GoodIssueNote gin;
        public ManageGIN()
        {
            InitializeComponent();
        }

        private void ManageGIN_Load(object sender, EventArgs e)
        {
            gin = new GoodIssueNote();
            dt = new DataTable();
            dt = gin.getGIN();
            dataGridGIN.DataSource = dt;
            dataGridGIN.Columns[2].Width = 200;
        }      

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            gin = new GoodIssueNote();
            dt = new DataTable();
            dt = gin.searchGIN(txtName.Text);
            dataGridGIN.DataSource = dt;
            dataGridGIN.Columns[2].Width = 200;
        }

        private void dataGridGIN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gin = new GoodIssueNote();
            if (dataGridGIN.CurrentRow != null)
            {
                int selectedGinId = Convert.ToInt32(dataGridGIN.CurrentRow.Cells[0].Value);
                dt1 = new DataTable();
                dt1 = gin.viewReleventGin(selectedGinId);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("No GIN Found!");
                else
                {
                    dataGridCusName.DataSource = dt1;
                    dataGridCusName.Columns[3].Width = 200;
                }                
            }
        }
    }
}

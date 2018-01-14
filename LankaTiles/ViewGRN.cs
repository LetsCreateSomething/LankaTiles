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
    public partial class ViewGRN : Form
    {
        public DataTable dt;
        public ViewGRN()
        {
            InitializeComponent();
        }

        private void ViewGRN_Load(object sender, EventArgs e)
        {
            GoodRecieveNote grn = new GoodRecieveNote();
            dt = grn.getGRN();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int selectedGRNID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (selectedGRNID != null)
                {
                    GoodRecieveNote grn = new GoodRecieveNote();
                    dt = grn.getGRN(selectedGRNID);

                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns[3].Visible = false;
                }
                if (e.ColumnIndex == 3)
                {               
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    GoodRecieveNote grn = new GoodRecieveNote();
                    grn.updateGRN(id);
                    Item item = new Item();
                    item.updateStock(id.ToString());
                    MessageBox.Show("Item Added!");
                }
           
           

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int selectedItemId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
            Item item = new Item();
            string rfid;
            rfid = item.getItemRfid(selectedItemId);
            RFID Rfid = new RFID();
            bool mark;
            mark = Rfid.verify(rfid);
        }
    }
}

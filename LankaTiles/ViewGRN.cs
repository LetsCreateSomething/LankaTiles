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
        DataTable dt;
        GoodRecieveNote grn;
        Item item;
        RFID Rfid;
        string rfid;
        int selectedGRNID;
        public ViewGRN()
        {
            InitializeComponent();
        }

        private void ViewGRN_Load(object sender, EventArgs e)
        {
            grn = new GoodRecieveNote();
            dt = grn.getGRN();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[3].Width = 200;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                selectedGRNID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                grn = new GoodRecieveNote();
                dt = grn.getGRN(selectedGRNID);

                dataGridView2.DataSource = dt;
                dataGridView2.Columns[3].Visible = false;

                if (e.ColumnIndex == 4)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    grn = new GoodRecieveNote();
                    int flag = grn.updateGRN(id);
                    if (flag==1)
                    {
                        item = new Item();
                        item.updateStock(id.ToString());
                        MessageBox.Show("Item Added!");
                    }                               
                }
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int selectedItemId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
            item = new Item();            
            rfid = item.getItemRfid(selectedItemId);
            Rfid = new RFID();
            bool mark;
            mark = Rfid.verify(rfid);
        }
    }
}

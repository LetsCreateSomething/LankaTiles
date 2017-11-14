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
    public partial class RemoveTON : Form
    {
        public DataTable dt;
        public RemoveTON()
        {
            InitializeComponent();
        }

        private void RemoveTON_Load(object sender, EventArgs e)
        {
            TransferOutNote ton = new TransferOutNote();
            dt = new DataTable();
            dt = ton.getTON();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("There are no Good Issue Notes Currently!");
                this.Close();
            }
            else
            {
                TONview.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TransferOutNote ton = new TransferOutNote();
            dt = new DataTable();
            dt = ton.searchTON(txtName.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No data found!");
            }
            else
            {
                TONview.DataSource = dt;
            }
        }

        private void btnRemoveTON_Click(object sender, EventArgs e)
        {
            TransferOutNote ton = new TransferOutNote();
            int selectedTONId = Convert.ToInt32(TONview.CurrentRow.Cells[0].Value);
            DialogResult dr = MessageBox.Show("Are You Sure?", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                ton.removeTON(selectedTONId);
                MessageBox.Show("TON deleted");
                dt = new DataTable();
                dt = ton.getTON();
                TONview.DataSource = dt;
            }
            txtName.Clear();
        }
    }
}

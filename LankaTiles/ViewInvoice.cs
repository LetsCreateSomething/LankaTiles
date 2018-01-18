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
    public partial class ViewInvoice : Form
    {
        DataTable dt1, dt2;
        Invoice invoice;
        public ViewInvoice()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            invoice = new Invoice();
            dt1 = new DataTable();
            int selectedInvID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            dt1 = invoice.getInvoice(selectedInvID);
            dataGridView2.DataSource = dt1;
            dataGridView2.Columns[5].Visible = false;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            invoice = new Invoice();
            dt1 = new DataTable();
            dt1 = invoice.search(txtSearch.Text);

            dataGridView1.DataSource = dt1;

            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[1].Width = 200;
        }

        private void ViewInvoice_Load(object sender, EventArgs e)
        {
            invoice = new Invoice();
            dt1 = new DataTable();
            dt1 = invoice.getInvoice();
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[1].Width = 200;
        }
    }
}

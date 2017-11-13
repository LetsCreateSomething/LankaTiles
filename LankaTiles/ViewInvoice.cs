﻿using System;
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
        public DataTable dt1, dt2;
        public ViewInvoice()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Invoice invoice = new Invoice();
            dt1 = new DataTable();
            int selectedInvID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            dt1 = invoice.getInvoice(selectedInvID);
            dataGridView2.DataSource = dt1;
        }

        private void ViewInvoice_Load(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            dt1 = new DataTable();
            dt1 = invoice.getInvoice();
            dataGridView1.DataSource = dt1;
        }
    }
}

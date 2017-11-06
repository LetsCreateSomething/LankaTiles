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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            viewTin.Visible = true;

            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;

            viewGrn.Visible = false;
            addGrn.Visible = false;

            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;

            stockBal.Visible = false;
            uncollect.Visible = false;

           
            viewInvoice.Visible = false;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            viewTin.Visible = false;

            addTon.Visible = true;
            viewTon.Visible = true;
            updateTon.Visible = true;
            removeTon.Visible = true;

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;

            viewGrn.Visible = false;
            addGrn.Visible = false;

            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;

            stockBal.Visible = false;
            uncollect.Visible = false;

            
            viewInvoice.Visible = false;
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            viewTin.Visible = false;

            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = true;
            removeGin.Visible = true;
            viewGin.Visible = true;

            viewGrn.Visible = false;
            addGrn.Visible = false;

            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;

            stockBal.Visible = false;
            uncollect.Visible = false;

          
            viewInvoice.Visible = false;
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            viewTin.Visible = false;

            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;

            viewGrn.Visible = true;
            addGrn.Visible = true;

            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;

            stockBal.Visible = false;
            uncollect.Visible = false;

           
            viewInvoice.Visible = false;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            viewTin.Visible = false;

            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;

            viewGrn.Visible = false;
            addGrn.Visible = false;

            report1.Visible = true;
            report2.Visible = true;
            report3.Visible = true;
            report4.Visible = true;

            stockBal.Visible = false;
            uncollect.Visible = false;

          
            viewInvoice.Visible = false;
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            viewTin.Visible = false;

            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;

            viewGrn.Visible = false;
            addGrn.Visible = false;

            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;

            stockBal.Visible = true;
            uncollect.Visible = true;

           
            viewInvoice.Visible = false;
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            viewTin.Visible = false;

            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;

            viewGrn.Visible = false;
            addGrn.Visible = false;

            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;

            stockBal.Visible = false;
            uncollect.Visible = false;

           
            viewInvoice.Visible = true;
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addTIN_Click(object sender, EventArgs e)
        {
           
        }

        private void viewTin_Click(object sender, EventArgs e)
        {
            ViewTIN frmViewTin = new ViewTIN();
            frmViewTin.ShowDialog();
        }

        private void addTon_Click(object sender, EventArgs e)
        {
            AddTON frmAddTon = new AddTON();
            frmAddTon.ShowDialog();
        }

        private void viewTon_Click(object sender, EventArgs e)
        {
            ViewTON frmViewTon = new ViewTON();
            frmViewTon.ShowDialog();
        }

        private void updateTon_Click(object sender, EventArgs e)
        {
            UpdateTON frmUpdateTon = new UpdateTON();
            frmUpdateTon.ShowDialog();
        }

        private void removeTon_Click(object sender, EventArgs e)
        {
            RemoveTON frmRemoveTon = new RemoveTON();
            frmRemoveTon.ShowDialog();
        }

        private void addGin_Click(object sender, EventArgs e)
        {
            AddGIN frmAddGin = new AddGIN();
            frmAddGin.ShowDialog();
        }

        private void removeGin_Click(object sender, EventArgs e)
        {
            RemoveGIN frmRemoveGin = new RemoveGIN();
            frmRemoveGin.ShowDialog();
        }

        private void viewGin_Click(object sender, EventArgs e)
        {
            ManageGIN frmManageGin = new ManageGIN();
            frmManageGin.ShowDialog();
        }

        private void viewGrn_Click(object sender, EventArgs e)
        {
            ViewGRN frmViewGrn = new ViewGRN();
            frmViewGrn.ShowDialog();
        }

        private void addGrn_Click(object sender, EventArgs e)
        {
            AddGRN frmAddGrn = new AddGRN();
            frmAddGrn.ShowDialog();
        }

        private void report1_Click(object sender, EventArgs e)
        {
            StockReports frmStockReports = new StockReports();
            frmStockReports.ShowDialog();
        }

        private void report2_Click(object sender, EventArgs e)
        {
            GoodRecieveReports goodRecieveReports = new GoodRecieveReports();
            goodRecieveReports.ShowDialog();
        }

        private void report3_Click(object sender, EventArgs e)
        {
            DecripancyDetailsReports frmDDR = new DecripancyDetailsReports();
            frmDDR.ShowDialog();
        }

        private void report4_Click(object sender, EventArgs e)
        {
            GoodIssueReports goodIssueReports = new GoodIssueReports();
            goodIssueReports.ShowDialog();
        }

        private void stockBal_Click(object sender, EventArgs e)
        {
            StockBalance frmStockBalance = new StockBalance();
            frmStockBalance.ShowDialog();
        }

        private void uncollect_Click(object sender, EventArgs e)
        {
            UncollectedItems uncollectedItems = new UncollectedItems();
            uncollectedItems.ShowDialog();
        }

        private void addInvoice_Click(object sender, EventArgs e)
        {
            
        }

        private void viewInvoice_Click(object sender, EventArgs e)
        {
            ViewInvoice frmViewInvoice = new ViewInvoice();
            frmViewInvoice.ShowDialog();
        }

        private void removeInvoce_Click(object sender, EventArgs e)
        {
           
        }
    }
}

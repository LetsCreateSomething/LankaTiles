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
            addTIN.Visible = true;
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

            addTIN.Visible = false;
            addTon.Visible = true;
            viewTon.Visible = true;
            if (Form1.pass == "manager")
            {
                updateTon.Visible = true;
                removeTon.Visible = true;
            }
            else
            {
                updateTon.Visible = false;
                removeTon.Visible = false;
            }
            

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
            addTIN.Visible = false;
            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = true;
            if (Form1.pass == "manager")
            {
                removeGin.Visible = true;
            }
            else
            {
                removeGin.Visible = false;
            }
            
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
            addTIN.Visible = false;
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
            addTIN.Visible = false;
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
            addTIN.Visible = false;
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
            addTIN.Visible = false;
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
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
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
            IssueTON frmAddTon = new IssueTON();
            frmAddTon.ShowDialog();
        }

        private void viewTon_Click(object sender, EventArgs e)
        {
            ViewTON frmViewTon = new ViewTON();
            frmViewTon.ShowDialog();
        }

        private void updateTon_Click(object sender, EventArgs e)
        {
            
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

        private void Home_Load(object sender, EventArgs e)
        {
            InitTimer();
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 3000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from TON where IsRecieved = 0");
            if (dt.Rows.Count > 0)
            {
                lblTINNotification.Text = "*";
            }
            else
            {
                lblTINNotification.Text = "";
            }

        }

        private void addTIN_Click_1(object sender, EventArgs e)
        {
            AddTIN addTIN = new AddTIN();
            addTIN.ShowDialog();
        }
    }
}

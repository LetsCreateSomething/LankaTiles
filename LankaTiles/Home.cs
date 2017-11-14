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
            tinReport.Visible = false;           
            viewTin.Visible = true;
            addTIN.Visible = true;
            addTon.Visible = false;
            viewTon.Visible = false;           
            removeTon.Visible = false;
            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;
            viewGrn.Visible = false;
            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;
            uncollect.Visible = false;
            viewInvoice.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tinReport.Visible = false;
            viewTin.Visible = false;          
            addTIN.Visible = false;
            addTon.Visible = true;
            viewTon.Visible = true;
            if (Form1.pass == "manager")
            {             
                removeTon.Visible = true;
            }
            else
            {               
                removeTon.Visible = false;
            }

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;
            viewGrn.Visible = false;
            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;            
            uncollect.Visible = false;
            viewInvoice.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tinReport.Visible = false;          
            viewTin.Visible = false;
            addTIN.Visible = false;
            addTon.Visible = false;
            viewTon.Visible = false;           
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
            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;
            uncollect.Visible = false;
            viewInvoice.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tinReport.Visible = false;
            viewTin.Visible = false;
            addTIN.Visible = false;
            addTon.Visible = false;
            viewTon.Visible = false;           
            removeTon.Visible = false;           
            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;
            viewGrn.Visible = true;
            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;          
            uncollect.Visible = false;
            viewInvoice.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {           
            tinReport.Visible = true;
            viewTin.Visible = false;
            addTIN.Visible = false;
            addTon.Visible = false;
            viewTon.Visible = false;           
            removeTon.Visible = false;          
            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;
            viewGrn.Visible = false;
            report1.Visible = false;
            report2.Visible = true;
            report3.Visible = true;
            report4.Visible = true;         
            uncollect.Visible = false;
            viewInvoice.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tinReport.Visible = false;
            viewTin.Visible = false;
            addTIN.Visible = false;
            addTon.Visible = false;
            viewTon.Visible = false;           
            removeTon.Visible = false;           
            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;
            viewGrn.Visible = false;
            report1.Visible = true;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;            
            uncollect.Visible = true;
            viewInvoice.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tinReport.Visible = false;
            viewTin.Visible = false;
            addTIN.Visible = false;
            addTon.Visible = false;
            viewTon.Visible = false;           
            removeTon.Visible = false;          
            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;
            viewGrn.Visible = false;
            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;          
            uncollect.Visible = false;
            viewInvoice.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
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
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from TON where IsRecieved = 0 ");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string query = "insert into rptData values ('" + dt.Rows[i][0] + ""
                    + " (TON)', '" + dt.Rows[i][1] + "','" + dt.Rows[i][2] + "')";
                db.inserUpdateDelete(query);
            }

            dt = db.select("SELECT grn.GRNID, grn.date, sup.supName, sup.location, grn.IsDelivered FROM "
                + " GRN grn INNER JOIN Supplier sup ON grn.supID = sup.supID where grn.IsDelivered = 0");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string query = "insert into rptData values ( '" + dt.Rows[i][0] + ""
                    + " (GRN)', '" + dt.Rows[i][1] + "','" + dt.Rows[i][2] + " , " + dt.Rows[i][3].ToString() + "')";
                db.inserUpdateDelete(query);
            }

            UncollectedItems uncollectedItems = new UncollectedItems();
            uncollectedItems.ShowDialog();
        }
             
        private void viewInvoice_Click(object sender, EventArgs e)
        {
            ViewInvoice frmViewInvoice = new ViewInvoice();
            frmViewInvoice.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            InitTimer();
            Database db = new Database();
            db.inserUpdateDelete("delete from rptData");
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
            DataTable dt,dt2 = new DataTable();
            dt = db.select("select * from TON where IsRecieved = 0");
            if (dt.Rows.Count > 0)
            {
                lblTINNotification.Text = "*";
            }
            else
            {
                lblTINNotification.Text = "";
            }

            dt2 = db.select("select * from GRN where IsDelivered = 0");
            if (dt2.Rows.Count > 0)
            {
                lblGRNNotification.Text = "*";
            }
            else
            {
                lblGRNNotification.Text = "";
            }

        }

        private void addTIN_Click_1(object sender, EventArgs e)
        {
            AddTIN addTIN = new AddTIN();
            addTIN.ShowDialog();
        }

        private void ginReport_Click(object sender, EventArgs e)
        {
           
        }

        private void tinReport_Click(object sender, EventArgs e)
        {
            TINReport tONReport = new TINReport();
            tONReport.ShowDialog();
        }
    }
}

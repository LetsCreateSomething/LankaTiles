using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace LankaTiles
{
    public partial class StockReports : Form
    {
        public StockReports()
        {
            InitializeComponent();
        }

        private void StockReports_Load(object sender, EventArgs e)
        {            
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:/Users/Sashika/source/repos/LankaTiles/LankaTiles/Reports/StockReport.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();          
        }
    }
}

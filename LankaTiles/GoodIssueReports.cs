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
using CrystalDecisions.Shared;

namespace LankaTiles
{
    public partial class GoodIssueReports : Form
    {
        public GoodIssueReports()
        {
            InitializeComponent();
        }

        private void GoodIssueReports_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Application.StartupPath + "\\Reports\\GINReport.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            ParameterFields paramFields = new ParameterFields();
            ParameterField paraCompAddresss1 = new ParameterField();
            ParameterDiscreteValue decCompAddresss1 = new ParameterDiscreteValue();
            decCompAddresss1.Value = Form1.pass;
            paraCompAddresss1.Name = "userID";
            paraCompAddresss1.CurrentValues.Add(decCompAddresss1);
            paramFields.Add(paraCompAddresss1);
            crystalReportViewer1.ParameterFieldInfo = paramFields;

            crystalReportViewer1.Show();
        }
    }
}

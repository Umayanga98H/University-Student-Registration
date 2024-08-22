using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CrystalDecisions.CrystalReport.Engine;

namespace Tutorial2
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form1 formnew = new Form1();
            //formnew.ShowDialog();
            this.Dispose();

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            /*ReportDocument report1 = new ReportDocument();
            report1.Load("paste the path of crystal report");
            crystalReportViewe1.reportSource = report1;
            crystalReportViewer1.Refresh();*/
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Details form = new Details();
            form.ShowDialog();
            this.Dispose();

        }

        private void studentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration form = new Registration();
            form.ShowDialog();
            this.Dispose();

        }

        private void studentsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports form = new Reports();
            form.ShowDialog();
            this.Dispose();
        }
    }
}

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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form1 form = new Form1();
            //form.ShowDialog();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                sqlDataAdapter1.Update(dSstudent1);
            }
            catch(Exception e1)
            {
                MessageBox.Show("Exception:" + e1);
            }
        }

        private void Details_Load(object sender, EventArgs e)
        {
            dSstudent1.Clear();
            sqlDataAdapter1.Fill(dSstudent1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(dSstudent1);

        }
    }
}

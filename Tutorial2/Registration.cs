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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form1 form = new Form1();
            //form.ShowDialog();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean validToSubmit = validate();

            if (validToSubmit)
            {
                MessageBox.Show("Congratulations!.You have registerd succesfully.");
            }
            else
            {
                MessageBox.Show("Sorry!!you should fill all the fileds to register.");
            }
        }

        private Boolean validate()
        {
            if (txtName.TextLength==0)
            {
                return false;
            }else if (txtAge.TextLength == 0)
            {
                return false;
            }else if (txtCountry.TextLength == 0)
            {
                return false;
            }else if (!(radioMale.Checked || radioFemale.Checked))//(!radioMale.Checked && !radioFemale.Checked)
            {
                return false;
            }else if (cmbDgree.SelectedIndex == (-1))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}

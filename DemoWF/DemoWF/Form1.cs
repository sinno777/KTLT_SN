using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWF
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pass = txtPass.Text;

            if(name == "" && pass == "")
                MessageBox.Show("Your information empty!");
            else if (name == "")
                MessageBox.Show("Your Name empty!");
            else if (pass == "")
                MessageBox.Show("Your Password empty!");
            else if (name == "khoadeptrai" && pass == "1101")
                MessageBox.Show("Success!");
            else
                MessageBox.Show("Check again Name and Password!");
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

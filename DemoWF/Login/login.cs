using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string pass = txtPass.Text;

            if (name == "" && pass == "")
                MessageBox.Show("Your information empty!");
            else if (name == "")
                MessageBox.Show("Your Name empty!");
            else if (pass == "")
                MessageBox.Show("Your Password empty!");
            else if (name == "khoadeptrai" && pass == "1101")
            {
                MessageBox.Show("Success!");
                this.Hide();
            }
            else
                MessageBox.Show("Check again Name and Password!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
                txtPass.PasswordChar = new char();
            else
                txtPass.PasswordChar = '*';

        }
    }
}

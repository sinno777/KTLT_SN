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
    public partial class sum : Form
    {
        public sum()
        {
            InitializeComponent();
        }

        private void sum_Load(object sender, EventArgs e)
        {
            Form frm = new login();
            frm.ShowDialog();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);

            int sum = n1 + n2;

            txtResult.Text = sum.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
98
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain myForm = new frmMain(theCWID.Text);
            if (myForm.ShowDialog() == DialogResult.OK)
            {
                

            }
            else
            {
                this.Close();

            }
        }
    }
}

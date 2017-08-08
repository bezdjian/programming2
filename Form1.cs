using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msg = "Password is: " + tbPasswd.Text;
            MessageBox.Show(msg, "Message");
        }

        private void btnShowMe_Click(object sender, EventArgs e)
        {
            lblShowPasswd.Text = tbPasswd.Text;
        }
    }
}

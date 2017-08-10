using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnServ_Click(object sender, EventArgs e)
        {
            string output = "";
            if(chkVodka.Checked && !chkGin.Checked)
            {
                output = "Vodka serveras ";
            }
            if(chkGin.Checked && !chkVodka.Checked)
            {
                output = "Gin serveras ";
            }
            if(chkVodka.Checked && chkGin.Checked)
            {
                output = "Vodka och Gin serveras ";
            }
            if (optCocktailGlass.Checked)
            {
                output += "i cochtailglas";
            }
            if (optShotGlass.Checked)
            {
                output += "i shotglas";
            }
            if (optVinGlass.Checked)
            {
                output += "i vinglas";
            }

            MessageBox.Show(output, "Bartender svarar");
        }
    }
}

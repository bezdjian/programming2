using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tax_calculator_1._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            double balance; //inläsning
            double capital = Convert.ToDouble(tbCapital.Text);
            double taxRate = Convert.ToDouble(tbTaxRate.Text);
            int years = Convert.ToInt32(numericUpDown1.Value);

            string output = "År\t\tSaldo\r\n\r\n";

            for(int n = 1; n <= years; n++)
            {
                balance = capital * (Math.Pow((1 + taxRate / 100), n));
                output += n + "\t\t" +  //Formaterad urskrift
                        string.Format("{0:C}", balance) + "\r\n"; //C = Currancy
            }

            tbDisplay.Text = output;
        }
    }
}

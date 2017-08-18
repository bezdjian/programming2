using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deliverydate_1._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime orderDate = dateTimePicker1.Value;

            if(orderDate.DayOfWeek == DayOfWeek.Friday ||
               orderDate.DayOfWeek == DayOfWeek.Saturday ||
               orderDate.DayOfWeek == DayOfWeek.Sunday){
                outputLabel.Text = orderDate.AddDays(3).ToLongDateString();
            }else{
                outputLabel.Text = orderDate.AddDays(2).ToLongDateString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MDI_1._12
{
    public partial class childForm : Form
    {
        public childForm(string title, string filename)
        {
            InitializeComponent();
            Text = title;
            pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + filename);
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void child1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm child = new childForm("Första bilden", "\\sky.jpg");
            child.MdiParent = this;
            //MessageBox.Show(Directory.GetCurrentDirectory() + "\\skyy.jpg", "rrr");
            child.Show();
        }

        private void child2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm child = new childForm("Andra bilden", "\\skyy.jpg");
            child.MdiParent = this;
            child.Text = "CHILD 2222";
            child.Show();
        }

        private void child3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm child = new childForm("Tredje bilden", "skyy.jpg");
            child.MdiParent = this;
            child.Text = "CHILD 3333";
            child.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}

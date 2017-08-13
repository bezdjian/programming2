using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstBrowser
{
    public partial class Form1 : Form
    {
        AboutBox myAboutBox = new AboutBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            browserWindow.Navigate(tbUrl.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myAboutBox.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void navigateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Navigate myNavigate = new Navigate();
            if(myNavigate.ShowDialog() == DialogResult.OK)
            {
                browserWindow.Navigate(myNavigate.txtURL.Text);
            }
        }
    }
}

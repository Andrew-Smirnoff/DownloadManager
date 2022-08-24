using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogURL dlg = new DialogURL();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("URL Recieved");
            }
        }
    }
}

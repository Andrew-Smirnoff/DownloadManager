using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace DownloadManager
{
    public partial class SaveFile : Form
    {

        string url;
        public SaveFile(string urlStr)
        {
            url = urlStr;
            InitializeComponent();
        }

        public String path
        {
            set
            {

            }
            get
            {
                return this.pathTextBox.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog file = new FolderBrowserDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = Path.GetFileName(url);
                    pathTextBox.Text = file.SelectedPath + '\\' + filename;
                }
                catch
                {

                }
            }
        }
    }
}

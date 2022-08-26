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

namespace DownloadManager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void addURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strUrl = "";
            DialogURL dlg = new DialogURL();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    strUrl = dlg.WebURL;
                    ListViewItem item = new ListViewItem(strUrl);

                    WebRequest req = WebRequest.Create(strUrl);
                    req.Method = "HEAD";
                    using (WebResponse resp = req.GetResponse())
                    {
                        var fileSize = resp.Headers.Get("Content-Length");
                        var fileSizeInMegaByte = Math.Round((Convert.ToDouble(fileSize) * .000001), 2);
                        item.SubItems.Add(fileSizeInMegaByte.ToString() + " MB");
                    }

                    this.listView1.Items.Add(item);
                }
                catch
                {

                }
            }

            SaveFile saveFile = new SaveFile(strUrl);
            Console.WriteLine("Check");
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = @saveFile.path;

                    using (WebClient wc = new WebClient())
                    {
                        Console.WriteLine(path);
                        wc.DownloadFile(strUrl, path);
                    }
                }
                catch
                {
                    Console.WriteLine("fail");
                }
            }
        }
    }
}

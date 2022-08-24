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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void addURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogURL dlg = new DialogURL();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string strUrl = dlg.WebURL;
                    ListViewItem item = new ListViewItem(strUrl);

                    System.Net.WebRequest req = System.Net.WebRequest.Create(strUrl);
                    req.Method = "HEAD";
                    using (System.Net.WebResponse resp = req.GetResponse())
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
        }
    }
}

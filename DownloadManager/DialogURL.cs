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
    public partial class DialogURL : Form
    {
        public DialogURL()
        {
            InitializeComponent();
        }

        public String WebURL
        {
            set
            {

            }
            get
            {
                return this.textBox1.Text;
            }
        }
    }
}

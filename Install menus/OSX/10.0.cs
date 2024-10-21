using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetThatOS.Install_menus.OSX
{
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mac = "https://github.com/breathemonoxide/diskimages/releases/download/osx10.0/osx-10.0.iso";
            string directoryPath = textBox1.Text;
            string fileName = "osx-10.0.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(mac, fullPath);
            }
            MessageBox.Show("Download complete");
        }
    }
    }


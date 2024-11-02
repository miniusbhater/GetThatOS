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
    public partial class _111 : Form
    {
        public _111()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mac = "http://updates-http.cdn-apple.com/2019/cert/061-41424-20191024-218af9ec-cf50-4516-9011-228c78eda3d2/InstallMacOSX.dmg";
            string directoryPath = textBox1.Text;
            string fileName = "InstallMacOSX.dmg";
            string fullPath = Path.Combine(directoryPath, fileName);

            button2.Enabled = false;
            button2.Font = new Font(button2.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button2.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button2.Text = "Download";
                    button2.Enabled = true;
                    button2.Font = new Font(button2.Font.FontFamily, 8.25f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(mac), fullPath);
            }

        }
    }
}

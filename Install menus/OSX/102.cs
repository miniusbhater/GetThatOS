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
    public partial class _102 : Form
    {
        public _102()
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
            string mac = "https://github.com/breathemonoxide/diskimages/releases/download/10.2/disk1.iso";
            string directoryPath = textBox1.Text;
            string fileName = "osx-10.2-disk1.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            string mac1 = "https://github.com/breathemonoxide/diskimages/releases/download/10.2/disk2.iso";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "osx-10.2-disk2.iso";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            WebClient webclient = new WebClient();
            WebClient webclient1 = new WebClient();

            int progress = 0;
            int progress1 = 0;

            webclient.DownloadProgressChanged += (s, ev) =>
            {
                progress = ev.ProgressPercentage;
                UpdateCombinedProgress(progress, progress1);
            };

            webclient1.DownloadProgressChanged += (s, ev) =>
            {
                progress1 = ev.ProgressPercentage;
                UpdateCombinedProgress(progress, progress1);
            };

            webclient.DownloadFileCompleted += (s, ev) =>
            {
                webclient.Dispose();
                CheckIfDownloadsComplete();
            };

            webclient1.DownloadFileCompleted += (s, ev) =>
            {
                webclient1.Dispose();
                CheckIfDownloadsComplete();
            };

            webclient.DownloadFileAsync(new Uri(mac), fullPath);
            webclient1.DownloadFileAsync(new Uri(mac1), fullPath1);
        }

        private void UpdateCombinedProgress(int progress, int progress1)
        {
            int combinedProgress = (progress + progress1) / 2;
            button1.Text = $"Downloading... {combinedProgress}%";
        }

        private void CheckIfDownloadsComplete()
        {
            if (!button1.Enabled) 
            {
                button1.Text = "Download";
                button1.Enabled = true;
                button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                MessageBox.Show("Download complete", "Status");
            }
        }

    }
}

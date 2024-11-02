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
    public partial class _103 : Form
    {
        public _103()
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
            string mac = "https://github.com/breathemonoxide/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.1.iso";
            string directoryPath = textBox1.Text;
            string fileName = "osx-10.3-disk1.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            string mac1 = "https://github.com/breathemonoxide/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.2.iso";
            string fileName1 = "osx-10.3-disk2.iso";
            string fullPath1 = Path.Combine(directoryPath, fileName1);

            string mac2 = "https://github.com/breathemonoxide/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.3.iso";
            string fileName2 = "osx-10.3-disk3.iso";
            string fullPath2 = Path.Combine(directoryPath, fileName2);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            WebClient webclient = new WebClient();
            WebClient webclient1 = new WebClient();
            WebClient webclient2 = new WebClient();

            int progress = 0, progress1 = 0, progress2 = 0;

            webclient.DownloadProgressChanged += (s, ev) =>
            {
                progress = ev.ProgressPercentage;
                UpdateCombinedProgress(progress, progress1, progress2);
            };

            webclient1.DownloadProgressChanged += (s, ev) =>
            {
                progress1 = ev.ProgressPercentage;
                UpdateCombinedProgress(progress, progress1, progress2);
            };

            webclient2.DownloadProgressChanged += (s, ev) =>
            {
                progress2 = ev.ProgressPercentage;
                UpdateCombinedProgress(progress, progress1, progress2);
            };

            webclient.DownloadFileCompleted += (s, ev) =>
            {
                webclient.Dispose();
                CheckIfDownloadsComplete2();
            };

            webclient1.DownloadFileCompleted += (s, ev) =>
            {
                webclient1.Dispose();
                CheckIfDownloadsComplete2();
            };

            webclient2.DownloadFileCompleted += (s, ev) =>
            {
                webclient2.Dispose();
                CheckIfDownloadsComplete2();
            };

            webclient.DownloadFileAsync(new Uri(mac), fullPath);
            webclient1.DownloadFileAsync(new Uri(mac1), fullPath1);
            webclient2.DownloadFileAsync(new Uri(mac2), fullPath2);
        }

        private void UpdateCombinedProgress(int progress, int progress1, int progress2)
        {
            int combinedProgress = (progress + progress1 + progress2) / 3; 
            button1.Text = $"Downloading... {combinedProgress}%";
        }

        private void CheckIfDownloadsComplete2()
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


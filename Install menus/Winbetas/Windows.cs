using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetThatOS.Install_menus.Winbetas
{
    public partial class Windows : Form
    {
        public Windows()
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
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/DR5/disk01.img";
            string directoryPath = textBox1.Text;
            string fileName = "disk01.IMG";
            string fullPath = Path.Combine(directoryPath, fileName);

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/DR5/disk02.img";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "disk02.IMG";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/DR5/disk03.img";
            string directoryPath2 = textBox1.Text;
            string fileName2 = "disk03.IMG";
            string fullPath2 = Path.Combine(directoryPath2, fileName2);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            WebClient webclient = new WebClient();
            WebClient webclient1 = new WebClient();
            WebClient webclient2 = new WebClient();

            int progress = 0;
            int progress1 = 0;
            int progress2 = 0;

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
                CheckIfDownloadsComplete();
            };

            webclient1.DownloadFileCompleted += (s, ev) =>
            {
                webclient1.Dispose();
                CheckIfDownloadsComplete();
            };

            webclient2.DownloadFileCompleted += (s, ev) =>
            {
                webclient2.Dispose();
                CheckIfDownloadsComplete();
            };

            webclient.DownloadFileAsync(new Uri(win), fullPath);
            webclient1.DownloadFileAsync(new Uri(win1), fullPath1);
            webclient2.DownloadFileAsync(new Uri(win2), fullPath2);
        }

        private void UpdateCombinedProgress(int progress, int progress1, int progress2)
        {
            int combinedProgress = (progress + progress1 + progress2) / 3;
            button1.Text = $"Downloading... {combinedProgress}%";
        }

        private void CheckIfDownloadsComplete()
        {
            if (!button1.Enabled) 
            {
                button1.Text = "DR 5";
                button1.Enabled = true;
                button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                MessageBox.Show("Download finished", "Status");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/alpha/Disk01.img";
            string directoryPath = textBox1.Text;
            string fileName = "Disk01.IMG";
            string fullPath = Path.Combine(directoryPath, fileName);

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/alpha/Disk02.img";
            string fileName1 = "Disk02.IMG";
            string fullPath1 = Path.Combine(directoryPath, fileName1);

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/alpha/Disk03.img";
            string fileName2 = "Disk03.IMG";
            string fullPath2 = Path.Combine(directoryPath, fileName2);

            string win3 = "https://github.com/breathemonoxide/diskimages/releases/download/alpha/Disk04.img";
            string fileName3 = "Disk04.IMG";
            string fullPath3 = Path.Combine(directoryPath, fileName3);

            button2.Enabled = false;
            button2.Font = new Font(button2.Font.FontFamily, 9);

            WebClient webclient = new WebClient();
            WebClient webclient1 = new WebClient();
            WebClient webclient2 = new WebClient();
            WebClient webclient3 = new WebClient();

            int progress = 0, progress1 = 0, progress2 = 0, progress3 = 0;

            webclient.DownloadProgressChanged += (s, ev) =>
            {
                progress = ev.ProgressPercentage;
                UpdateCombinedProgress(progress, progress1, progress2, progress3);
            };

            webclient1.DownloadProgressChanged += (s, ev) =>
            {
                progress1 = ev.ProgressPercentage;
                UpdateCombinedProgress(progress, progress1, progress2, progress3);
            };

            webclient2.DownloadProgressChanged += (s, ev) =>
            {
                progress2 = ev.ProgressPercentage;
                UpdateCombinedProgress(progress, progress1, progress2, progress3);
            };

            webclient3.DownloadProgressChanged += (s, ev) =>
            {
                progress3 = ev.ProgressPercentage;
                UpdateCombinedProgress(progress, progress1, progress2, progress3);
            };

            webclient.DownloadFileCompleted += (s, ev) =>
            {
                webclient.Dispose();
                CheckIfDownloadsComplete1();
            };

            webclient1.DownloadFileCompleted += (s, ev) =>
            {
                webclient1.Dispose();
                CheckIfDownloadsComplete1();
            };

            webclient2.DownloadFileCompleted += (s, ev) =>
            {
                webclient2.Dispose();
                CheckIfDownloadsComplete1();
            };

            webclient3.DownloadFileCompleted += (s, ev) =>
            {
                webclient3.Dispose();
                CheckIfDownloadsComplete1();
            };

            webclient.DownloadFileAsync(new Uri(win), fullPath);
            webclient1.DownloadFileAsync(new Uri(win1), fullPath1);
            webclient2.DownloadFileAsync(new Uri(win2), fullPath2);
            webclient3.DownloadFileAsync(new Uri(win3), fullPath3);
        }

        private void UpdateCombinedProgress(int progress, int progress1, int progress2, int progress3)
        {
            int combinedProgress = (progress + progress1 + progress2 + progress3) / 4;
            button2.Text = $"Downloading... {combinedProgress}%";
        }

        private void CheckIfDownloadsComplete1()
        {
            if (!button2.Enabled) // This will indicate all downloads are complete
            {
                button2.Text = "Download";
                button2.Enabled = true;
                button2.Font = new Font(button2.Font.FontFamily, 15.75f);
                MessageBox.Show("Download finished", "Status");
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/beta/Setup.img";
            string directoryPath = textBox1.Text;
            string fileName = "Setup.IMG";
            string fullPath = Path.Combine(directoryPath, fileName);

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/beta/Applications.img";
            string fileName1 = "Applications.IMG";
            string fullPath1 = Path.Combine(directoryPath, fileName1);

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/beta/Utilities.img";
            string fileName2 = "Utilities.IMG";
            string fullPath2 = Path.Combine(directoryPath, fileName2);

            button3.Enabled = false;
            button3.Font = new Font(button3.Font.FontFamily, 9);

            WebClient webclient = new WebClient();
            WebClient webclient1 = new WebClient();
            WebClient webclient2 = new WebClient();

            int progress = 0, progress1 = 0, progress2 = 0;

            webclient.DownloadProgressChanged += (s, ev) =>
            {
                progress = ev.ProgressPercentage;
                UpdateCombinedProgress1(progress, progress1, progress2);
            };

            webclient1.DownloadProgressChanged += (s, ev) =>
            {
                progress1 = ev.ProgressPercentage;
                UpdateCombinedProgress1(progress, progress1, progress2);
            };

            webclient2.DownloadProgressChanged += (s, ev) =>
            {
                progress2 = ev.ProgressPercentage;
                UpdateCombinedProgress1(progress, progress1, progress2);
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

            webclient.DownloadFileAsync(new Uri(win), fullPath);
            webclient1.DownloadFileAsync(new Uri(win1), fullPath1);
            webclient2.DownloadFileAsync(new Uri(win2), fullPath2);
        }

        private void UpdateCombinedProgress1(int progress, int progress1, int progress2)
        {
            int combinedProgress = (progress + progress1 + progress2) / 3; // Average progress
            button3.Text = $"Downloading... {combinedProgress}%";
        }

        private void CheckIfDownloadsComplete2()
        {
            if (!button3.Enabled) // Indicates all downloads are complete
            {
                button3.Text = "Download";
                button3.Enabled = true;
                button3.Font = new Font(button3.Font.FontFamily, 15.75f);
                MessageBox.Show("Download finished", "Status");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/Premiere/disk01.img";
            string directoryPath = textBox1.Text;
            string fileName = "disk01.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/Premiere/disk02.img";
            string fileName1 = "disk02.img";
            string fullPath1 = Path.Combine(directoryPath, fileName1);

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/Premiere/disk03.img";
            string fileName2 = "disk03.img";
            string fullPath2 = Path.Combine(directoryPath, fileName2);

            string win3 = "https://github.com/breathemonoxide/diskimages/releases/download/Premiere/disk04.img";
            string fileName3 = "disk04.img";
            string fullPath3 = Path.Combine(directoryPath, fileName3);

            button4.Enabled = false;
            button4.Font = new Font(button4.Font.FontFamily, 9);

            WebClient webclient = new WebClient();
            WebClient webclient1 = new WebClient();
            WebClient webclient2 = new WebClient();
            WebClient webclient3 = new WebClient();

            int progress = 0, progress1 = 0, progress2 = 0, progress3 = 0;

            webclient.DownloadProgressChanged += (s, ev) =>
            {
                progress = ev.ProgressPercentage;
                UpdateCombinedProgress1(progress, progress1, progress2, progress3);
            };

            webclient1.DownloadProgressChanged += (s, ev) =>
            {
                progress1 = ev.ProgressPercentage;
                UpdateCombinedProgress1(progress, progress1, progress2, progress3);
            };

            webclient2.DownloadProgressChanged += (s, ev) =>
            {
                progress2 = ev.ProgressPercentage;
                UpdateCombinedProgress1(progress, progress1, progress2, progress3);
            };

            webclient3.DownloadProgressChanged += (s, ev) =>
            {
                progress3 = ev.ProgressPercentage;
                UpdateCombinedProgress1(progress, progress1, progress2, progress3);
            };

            webclient.DownloadFileCompleted += (s, ev) =>
            {
                webclient.Dispose();
                CheckIfDownloadsComplete21();
            };

            webclient1.DownloadFileCompleted += (s, ev) =>
            {
                webclient1.Dispose();
                CheckIfDownloadsComplete21();
            };

            webclient2.DownloadFileCompleted += (s, ev) =>
            {
                webclient2.Dispose();
                CheckIfDownloadsComplete21();
            };

            webclient3.DownloadFileCompleted += (s, ev) =>
            {
                webclient3.Dispose();
                CheckIfDownloadsComplete21();
            };

            webclient.DownloadFileAsync(new Uri(win), fullPath);
            webclient1.DownloadFileAsync(new Uri(win1), fullPath1);
            webclient2.DownloadFileAsync(new Uri(win2), fullPath2);
            webclient3.DownloadFileAsync(new Uri(win3), fullPath3);
        }

        private void UpdateCombinedProgress1(int progress, int progress1, int progress2, int progress3)
        {
            int combinedProgress = (progress + progress1 + progress2 + progress3) / 4; // Average progress
            button4.Text = $"Downloading... {combinedProgress}%";
        }

        private void CheckIfDownloadsComplete21()
        {
            if (!button4.Enabled) // Indicates all downloads are complete
            {
                button4.Text = "Download";
                button4.Enabled = true;
                button4.Font = new Font(button4.Font.FontFamily, 15.75f);
                MessageBox.Show("Download finished", "Status");
            }
        }


        private void Windows_Load(object sender, EventArgs e)
        {

        }
    }
}

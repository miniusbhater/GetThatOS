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

namespace GetThatOSUpdater
{
    public partial class old : Form
    {
        public old()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.2.2/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.2.2.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.2.2";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.2.1/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.2.1.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.2.1";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.2/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.2.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.2";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1.9-1/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.1.9-1.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.9-1";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1.9/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.1.9.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.9";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1.8/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.1.8.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.8";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1.7/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.1.7.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.7";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1.6/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.1.6.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.6";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1.5/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.1.5.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.5";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1.4/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.1.4.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.4";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1.3/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.1.3.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.3";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1.2/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.1.2.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.2";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1.1/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.1.1.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.1";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1/GetThatOS.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSV0.1.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.2.3/GetThatOSUpdater.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSUpdaterV0.1.3.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.3";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.2.2/GetThatOSUpdater.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSUpdaterV0.1.2.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.2";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1.5/GetThatOSUpdater.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSUpdaterV0.1.1.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1.1";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1.1/GetThatOSUpdater.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSUpdaterV0.1.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.1";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string os = "https://github.com/breathemonoxide/GetThatOS/releases/download/0.1/GetThatOSUpdater.exe";
            string directoryPath = textBox1.Text;
            string fileName = "GetThatOSUpdaterV0.0.9.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "0.0.9";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(os), fullPath);
            }
        }
    }
}

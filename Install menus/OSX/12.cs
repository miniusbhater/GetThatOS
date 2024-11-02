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
    public partial class _12 : Form
    {
        public _12()
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
            string mac = "https://swcdn.apple.com/content/downloads/34/21/062-40406-A_GZQ27OUQER/ggclib72ow1omcvfexvp84bc9x5ei5tyqu/InstallAssistant.pkg";
            string directoryPath = textBox1.Text;
            string fileName = "InstallAssistant.pkg";
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
                    button1.Text = "Download";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(mac), fullPath);
            }
        }
    }
    }


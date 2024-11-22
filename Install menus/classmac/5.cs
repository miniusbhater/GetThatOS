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

namespace GetThatOS.Install_menus.classmac
{
    public partial class _5 : Form
    {
        public _5()
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
            string mac = "https://github.com/breathemonoxide/diskimages/releases/download/5.0/System.Tools.1.img";
            string directoryPath = textBox1.Text;
            string fileName = "System.Tools.1.img";
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
                   
                };

                webclient.DownloadFileAsync(new Uri(mac), fullPath);

                string mac1 = "https://github.com/breathemonoxide/diskimages/releases/download/5.0/System.Tools.2.img";
                string directoryPath1 = textBox1.Text;
                string fileName1 = "System.Tools.2.img";
                string fullPath1 = Path.Combine(directoryPath1, fileName1);

                button1.Enabled = false;
                button1.Font = new Font(button1.Font.FontFamily, 9);

                using (WebClient webclient1 = new WebClient())
                {
                    webclient1.DownloadProgressChanged += (s1, ev1) =>
                    {
                        button1.Text = $"Downloading... {ev1.ProgressPercentage}%";
                    };

                    webclient1.DownloadFileCompleted += (s1, ev) =>
                    {
                        button1.Text = "Download";
                        button1.Enabled = true;
                        button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                   
                    };

                    webclient1.DownloadFileAsync(new Uri(mac1), fullPath1);
                }

                string mac11 = "https://github.com/breathemonoxide/diskimages/releases/download/5.0/Utilities.1.img";
                string directoryPath11 = textBox1.Text;
                string fileName11 = "Utilities.1.img";
                string fullPath11 = Path.Combine(directoryPath11, fileName11);

                button1.Enabled = false;
                button1.Font = new Font(button1.Font.FontFamily, 9);

                using (WebClient webclient11 = new WebClient())
                {
                    webclient11.DownloadProgressChanged += (s11, ev11) =>
                    {
                        button1.Text = $"Downloading... {ev11.ProgressPercentage}%";
                    };

                    webclient11.DownloadFileCompleted += (s1, ev) =>
                    {
                        button1.Text = "Download";
                        button1.Enabled = true;
                        button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                       
                    };

                    webclient11.DownloadFileAsync(new Uri(mac11), fullPath11);

                }
            }

            string mac111 = "https://github.com/breathemonoxide/diskimages/releases/download/5.0/Utilities.2.img";
            string directoryPath111 = textBox1.Text;
            string fileName111 = "Utilities.2.img";
            string fullPath111 = Path.Combine(directoryPath111, fileName111);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 9);

            using (WebClient webclient111 = new WebClient())
            {
                webclient111.DownloadProgressChanged += (s111, ev111) =>
                {
                    button1.Text = $"Downloading... {ev111.ProgressPercentage}%";
                };

                webclient111.DownloadFileCompleted += (s111, ev111) =>
                {
                    button1.Text = "Download";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient111.DownloadFileAsync(new Uri(mac111), fullPath111);

            }
        }

    }
    }

    


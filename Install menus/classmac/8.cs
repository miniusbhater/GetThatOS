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
    public partial class _8 : Form
    {
        public _8()
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
            string mac = "https://github.com/breathemonoxide/diskimages/releases/download/8.0/Apple.MacOS.8.0.m68k.iso";
            string directoryPath = textBox1.Text;
            string fileName = "MacOS8.0";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 5);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "8.0";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(mac), fullPath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mac = "https://github.com/breathemonoxide/diskimages/releases/download/8.1/MacOS8_1.iso";
            string directoryPath = textBox1.Text;
            string fileName = "MacOS8.1";
            string fullPath = Path.Combine(directoryPath, fileName);

            button2.Enabled = false;
            button2.Font = new Font(button2.Font.FontFamily, 5);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button2.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button2.Text = "8.1";
                    button2.Enabled = true;
                    button2.Font = new Font(button2.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(mac), fullPath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mac = "https://github.com/breathemonoxide/diskimages/releases/download/8.5/Apple.MacOS.8.5.PowerPC.iso";
            string directoryPath = textBox1.Text;
            string fileName = "MacOS8.5";
            string fullPath = Path.Combine(directoryPath, fileName);

            button3.Enabled = false;
            button3.Font = new Font(button3.Font.FontFamily, 5);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button3.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button3.Text = "8.5";
                    button3.Enabled = true;
                    button3.Font = new Font(button3.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(mac), fullPath);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mac = "https://github.com/breathemonoxide/diskimages/releases/download/8.6/MacOS86.iso";
            string directoryPath = textBox1.Text;
            string fileName = "MacOS8.6";
            string fullPath = Path.Combine(directoryPath, fileName);

            button4.Enabled = false;
            button4.Font = new Font(button4.Font.FontFamily, 5);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button4.Text = $"Downloading... {ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button4.Text = "8.6";
                    button4.Enabled = true;
                    button4.Font = new Font(button4.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(mac), fullPath);
            }
        }
    }
}

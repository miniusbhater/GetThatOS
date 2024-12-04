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

namespace GetThatOS.Install_menus.TempleOS
{
    public partial class tos : Form
    {
        public tos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mac = "https://templeos.org/Downloads/TempleOS.ISO";
            string directoryPath = textBox1.Text;
            string fileName = "TempleOS.ISO";
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

        private void button2_Click(object sender, EventArgs e)
        {
            string mac = "https://templeos.org/Downloads/TempleOSLite.ISO";
            string directoryPath = textBox1.Text;
            string fileName = "TempleOSLite.ISO";
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
                    button2.Text = "Lite";
                    button2.Enabled = true;
                    button2.Font = new Font(button2.Font.FontFamily, 15.75f);
                    MessageBox.Show("Download complete", "Status");
                };

                webclient.DownloadFileAsync(new Uri(mac), fullPath);
            }
        }
    }
}

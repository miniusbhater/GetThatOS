using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetThatOSUpdater
{
    public partial class updater : Form
    {
        public updater()
        {
            InitializeComponent();
        }

        private void updater_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string processName = "GetThatOS";
            Process[] processes = Process.GetProcessesByName(processName);

            foreach (Process process in processes)
            {
                process.Kill();
            }

            await Task.Delay(2000);

            string getosname = "GetThatOS.exe";
            string getos = AppDomain.CurrentDomain.BaseDirectory;
            string getosfull = Path.Combine(getos, getosname);
            File.Delete(getosfull);

            string updater = "https://github.com/breathemonoxide/GetThatOS/releases/latest/download/GetThatOS.exe";
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "GetThatOS.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            button1.Enabled = false;
            button1.Font = new Font(button1.Font.FontFamily, 8);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadProgressChanged += (s, ev) =>
                {
                    button1.Text = $"Downloading...\n{ev.ProgressPercentage}%";
                };

                webclient.DownloadFileCompleted += (s, ev) =>
                {
                    button1.Text = "Download";
                    button1.Enabled = true;
                    button1.Font = new Font(button1.Font.FontFamily, 12f);
                    MessageBox.Show("Download complete", "Status");
                    System.Diagnostics.Process.Start(fullPath);
                    System.Windows.Forms.Application.Exit();
                };

                webclient.DownloadFileAsync(new Uri(updater), fullPath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            string getosname = "GetThatOS.exe";
            string getos = AppDomain.CurrentDomain.BaseDirectory;
            string getosfull = Path.Combine(getos, getosname);

            Thread.Sleep(1500);

            System.Diagnostics.Process.Start(getosfull);
            System.Windows.Forms.Application.Exit();
        }
    }
}

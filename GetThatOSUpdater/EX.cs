using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace GetThatOSUpdater
{

 
    public partial class EX : Form
    {

        bool isbeta = false;
        public EX()
        {
            InitializeComponent();

            if (!isbeta)
            {
                button1.Text = "Already on release!";
                button1.Enabled = false;
          
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/breathemonoxide/GetThatOS");
            Process.Start("https://github.com/breathemonoxide/GetThatOS-beta");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string processName = "GetThatOS";
            Process[] processes = Process.GetProcessesByName(processName);

            foreach (Process process in processes)
            {
                process.Kill();
            }

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
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            old old = new old();
            old.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to remove GetThatOS?",
                 "Remove?",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                string updater = "https://github.com/breathemonoxide/GetThatOS/raw/main/GetThatOS0/GetThatOS0.exe";
                string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
                string fileName = "GetThatOS0.exe";
                string fullPath = Path.Combine(directoryPath, fileName);

                using (WebClient webclient = new WebClient())
                {
                    webclient.DownloadFile(updater, fullPath);
                }
                System.Diagnostics.Process.Start(fullPath);
                System.Windows.Forms.Application.Exit();
            }
        }

        private void EX_Load(object sender, EventArgs e)
        {

        }
    }
}

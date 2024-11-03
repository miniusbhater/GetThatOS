using GetThatOS.settings;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetThatOS.main
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string updater = "https://github.com/breathemonoxide/GetThatOS/releases/latest/download/GetThatOSUpdater.exe";
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "GetThatOSUpdater.exe";
            string fullPath = Path.Combine(directoryPath, fileName);
          
            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(updater, fullPath);
            }
            MessageBox.Show("Get that OS updater will start when you click ok");
            System.Diagnostics.Process.Start(fullPath);
            System.Windows.Forms.Application.Exit();
        }

        private void setting_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dis = new ProcessStartInfo

            {

                FileName = "https://discord.gg/dS6d7PET6W",

                UseShellExecute = true

            };

            Process.Start(dis);
        }
    }
}

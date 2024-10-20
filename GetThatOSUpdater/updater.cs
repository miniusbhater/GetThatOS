using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
            string processName = "GetThatOS";  
            Process[] processes = Process.GetProcessesByName(processName);

            foreach (Process process in processes)
            {
                process.Kill();
            }

            Thread.Sleep(2000);

            string getosname = "GetThatOS.exe";
            string getos = AppDomain.CurrentDomain.BaseDirectory;
            string getosfull = Path.Combine(getos, getosname);
            File.Delete(getosfull);

            string updater = "https://github.com/breathemonoxide/GetThatOS/releases/latest/download/GetThatOS.exe";
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "GetThatOS.exe";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(updater, fullPath);
            }
            MessageBox.Show("update finished GetThatOS will now start up");
            System.Diagnostics.Process.Start(fullPath);
            System.Windows.Forms.Application.Exit();
        }
    }
}

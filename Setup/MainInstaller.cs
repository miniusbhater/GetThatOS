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
using System.Diagnostics;
using System.Security.Cryptography;
using IWshRuntimeLibrary;

namespace GetThatOSSetup
{
    public partial class MainInstaller : Form
    {
        public MainInstaller()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label5.Text = ("Creating root folder");
            string ProgramFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string CreateFolder = Path.Combine(ProgramFiles, "GetThatOS");
            Directory.CreateDirectory(CreateFolder);
            label5.Text = ("Installing executable");
            string download = "https://github.com/miniusbhater/GetThatOS/raw/main/Executables/GetThatOS.exe";
            string output = Path.Combine(CreateFolder, "GetThatOS.exe");

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(new Uri(download), output);
            }
            label5.Text = ("Installing repo shorcut");
            string downloadurl = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/GetThatOS%20Repository.url";
            string outputurl = Path.Combine(CreateFolder, "GetThatOS Repository.url");

            using (WebClient webclienturl = new WebClient())
            {
                webclienturl.DownloadFile(new Uri(downloadurl), outputurl);
            }

            
            label5.Text = ("Creating resources folder");
            string ProgramFiles1 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string CreateFolder1 = Path.Combine(ProgramFiles1, "GetThatOS", "LogosAndImages");
            Directory.CreateDirectory(CreateFolder1);
            label5.Text = ("Installing resources");
            string download1 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/GetThatOS_logo.ico";
            string output1 = Path.Combine(CreateFolder1, "GetThatOS_logo.ico");

            using (WebClient webclient1 = new WebClient())
            {
                webclient1.DownloadFile(new Uri(download1), output1);
            }

            string download2 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/LinuxTux_logo.ico";
            string output2 = Path.Combine(CreateFolder1, "LinuxTux_logo.ico");

            using (WebClient webclient2 = new WebClient())
            {
                webclient2.DownloadFile(new Uri(download2), output2);
            }

            string download3 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/MacModern_logo.ico";
            string output3 = Path.Combine(CreateFolder1, "MacModern_logo.ico");

            using (WebClient webclient3 = new WebClient())
            {
                webclient3.DownloadFile(new Uri(download3), output3);
            }

            string download4 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/MacFlat_logo.ico";
            string output4 = Path.Combine(CreateFolder1, "MacFlat_logo.ico");

            using (WebClient webclient4 = new WebClient())
            {
                webclient4.DownloadFile(new Uri(download4), output4);
            }

            string download5 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/MacOSX_logo.ico";
            string output5 = Path.Combine(CreateFolder1, "MacOSX_logo.ico");

            using (WebClient webclient5 = new WebClient())
            {
                webclient5.DownloadFile(new Uri(download5), output5);
            }

            string download6 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/MacPreOSX_logo.ico";
            string output6 = Path.Combine(CreateFolder1, "MacPreOSX_logo.ico");

            using (WebClient webclient6 = new WebClient())
            {
                webclient6.DownloadFile(new Uri(download6), output6);
            }

            string download7 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/Windows11_logo.ico";
            string output7 = Path.Combine(CreateFolder1, "Windows11_logo.ico");

            using (WebClient webclient7 = new WebClient())
            {
                webclient7.DownloadFile(new Uri(download7), output7);
            }

            string download8 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/Windows10_logo.ico";
            string output8 = Path.Combine(CreateFolder1, "Windows10_logo.ico");

            using (WebClient webclient8 = new WebClient())
            {
                webclient8.DownloadFile(new Uri(download8), output8);
            }

            string download9 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/Windows8_logo.ico";
            string output9 = Path.Combine(CreateFolder1, "Windows8_logo.ico");

            using (WebClient webclient9 = new WebClient())
            {
                webclient9.DownloadFile(new Uri(download9), output9);
            }

            string download10 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/Windows7_logo.ico";
            string output10 = Path.Combine(CreateFolder1, "Windows7_logo.ico");

            using (WebClient webclient10 = new WebClient())
            {
                webclient10.DownloadFile(new Uri(download10), output10);
            }

            string download11 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/WindowsVista_logo.ico";
            string output11 = Path.Combine(CreateFolder1, "WindowsVista_logo.ico");

            using (WebClient webclient11 = new WebClient())
            {
                webclient11.DownloadFile(new Uri(download11), output11);
            }

            string download12 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/WindowsXP_logo.ico";
            string output12 = Path.Combine(CreateFolder1, "WindowsXP_logo.ico");

            using (WebClient webclient12 = new WebClient())
            {
                webclient12.DownloadFile(new Uri(download12), output12);
            }

            string download13 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/WindowsME_logo.ico";
            string output13 = Path.Combine(CreateFolder1, "WindowsME_logo.ico");

            using (WebClient webclient13 = new WebClient())
            {
                webclient13.DownloadFile(new Uri(download13), output13);
            }

            string download14 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/Windows2000_logo.ico";
            string output14 = Path.Combine(CreateFolder1, "Windows2000_logo.ico");

            using (WebClient webclient14 = new WebClient())
            {
                webclient14.DownloadFile(new Uri(download14), output14);
            }

            string download15 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/Windows98_logo.ico";
            string output15 = Path.Combine(CreateFolder1, "Windows98_logo.ico");

            using (WebClient webclient15 = new WebClient())
            {
                webclient15.DownloadFile(new Uri(download15), output15);
            }

            string download16 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/Windows95_logo.ico";
            string output16 = Path.Combine(CreateFolder1, "Windows95_logo.ico");

            using (WebClient webclient16 = new WebClient())
            {
                webclient16.DownloadFile(new Uri(download16), output16);
            }

            string download17 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/Windows3.1_logo.ico";
            string output17 = Path.Combine(CreateFolder1, "Windows3.1_logo.ico");

            using (WebClient webclient17 = new WebClient())
            {
                webclient17.DownloadFile(new Uri(download17), output17);
            }

            string download18 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/Windows2_logo.ico";
            string output18 = Path.Combine(CreateFolder1, "Windows2_logo.ico");

            using (WebClient webclient18 = new WebClient())
            {
                webclient18.DownloadFile(new Uri(download18), output18);
            }

            string download19 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/Windows_logo.ico";
            string output19 = Path.Combine(CreateFolder1, "Windows_logo.ico");

            using (WebClient webclient19 = new WebClient())
            {
                webclient19.DownloadFile(new Uri(download19), output19);
            }

            string download20 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/GetThatOSOther_logo.ico";
            string output20 = Path.Combine(CreateFolder1, "GetThatOSOther_logo.ico");

            using (WebClient webclient20 = new WebClient())
            {
                webclient20.DownloadFile(new Uri(download20), output20);
            }

            string download21 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/Windows98953_logo.ico";
            string output21 = Path.Combine(CreateFolder1, "Windows98953_logo.ico");

            using (WebClient webclient21 = new WebClient())
            {
                webclient21.DownloadFile(new Uri(download21), output21);
            }

            string download23 = "https://github.com/miniusbhater/GetThatOS/raw/main/GetThatOS%20Resources/LogosAndImages/coconut.jpg";
            string output23 = Path.Combine(CreateFolder1, "coconut.jpg");

            using (WebClient webclient23 = new WebClient())
            {
                webclient23.DownloadFile(new Uri(download23), output23);
            }


            label5.Text = ("Downloading GetThatIntegrity");

            string download22 = "https://github.com/miniusbhater/GetThatOS/raw/main/Executables/GetThatIntegrity.exe";
            string output22 = Path.Combine(CreateFolder, "GetThatIntegrity.exe");

            using (WebClient webclient22 = new WebClient())
            {
                webclient22.DownloadFile(new Uri(download22), output22);
            }

            label5.Text = ("Downloading GetThatUptime");

            string download24 = "https://github.com/miniusbhater/GetThatOS/raw/main/Executables/GetThatUptime.exe";
            string output24 = Path.Combine(CreateFolder, "GetThatUptime.exe");

            using (WebClient webclient24 = new WebClient())
            {
                webclient24.DownloadFile(new Uri(download24), output24);
            }

            label5.Text = ("Downloading GetThatUninstaller");

            string download25 = "https://github.com/miniusbhater/GetThatOS/raw/main/Executables/GetThatUninstaller.exe";
            string output25 = Path.Combine(CreateFolder, "GetThatUninstaller.exe");

            using (WebClient webclient25 = new WebClient())
            {
                webclient25.DownloadFile(new Uri(download25), output25);
            }

            label5.Text = ("Downloading GetThatUpdate");

            string download26 = "https://github.com/miniusbhater/GetThatOS/raw/main/Executables/GetThatUpdate.exe";
            string output26 = Path.Combine(CreateFolder, "GetThatUpdate.exe");

            using (WebClient webclient26 = new WebClient())
            {
                webclient26.DownloadFile(new Uri(download26), output26);
            }




            label5.Text = ("Creating start menu shortcut");
            string gosshortcut = "GetThatOS.lnk";
            string target = @"C:\Program Files (x86)\GetThatOS\GetThatOS.exe";
            string start = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
            string shortcutpath = Path.Combine(start, "Programs", gosshortcut);           
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutpath);
            shortcut.TargetPath = target;
            shortcut.WorkingDirectory = Path.GetDirectoryName(target);
            shortcut.Save();


                label5.Visible = false;
                label6.Visible = true;
                MessageBox.Show("Download complete!");
            }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void MainInstaller_Load(object sender, EventArgs e)
        {

        }
    }
}

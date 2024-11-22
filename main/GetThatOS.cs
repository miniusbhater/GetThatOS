using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using GetThatOS.Menus;
using GetThatOS.main;
using GetThatOS.Properties;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.IO;

namespace GetThatOS
{
    public partial class GetThatOS : Form
    {
        public GetThatOS()
        {
            InitializeComponent();
            ShowMessageOnFirstRun();

            string fileName = "GetThatOSUpdater.exe";
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, fileName);

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    Console.WriteLine($"{fileName} has been successfully deleted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while deleting the updater: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"{fileName} does not exist in the current directory.");
            }
        

            this.FormClosing += GetThatOS_FormClosing;
            this.Shown += async (sender, e) =>
            {

                await Task.Delay(100);


                RunAfterRender();
            };

        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/breathemonoxide/GetThatOS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WIndows win = new WIndows();
            win.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Linux lin = new Linux();
            lin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MacOS macOS = new MacOS();
            macOS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            More more = new More();
            more.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setting sett = new setting();
            sett.Show();
        }

        private void GetThatOS_Load(object sender, EventArgs e)
        {
            
        }
        private void RunAfterRender()
        {
            {
            }
        }
        private void GetThatOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ShowMessageOnFirstRun()
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolderPath = Path.Combine(appDataFolder, "GetThatOS");
            string filePath = Path.Combine(appFolderPath, "firstRun.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("This tool should only be downloaded from the official GitHub page: https://github.com/breathemonoxide/GetThatOS .\n If you downloaded the tool from a place other than my github, or have paid money for this program, you have been scammed. .\n run a virus scan on your computer ");

                if (!Directory.Exists(appFolderPath))
                {
                    Directory.CreateDirectory(appFolderPath);
                }

                File.WriteAllText(filePath, "first run has occured");
            }
        }
    }
}

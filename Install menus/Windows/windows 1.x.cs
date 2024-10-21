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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GetThatOS.Install_menus.Windows
{
    public partial class windows_1 : Form
    {
        public windows_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/1.01/DISK1-SETUP.IMG";
            string directoryPath = textBox1.Text;
            string fileName = "DISK1-SETUP.IMG";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/1.01/DISK2-BUILD.IMG";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "DISK2-BUILD.IMG";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/1.01/DISK3-UTILITY.IMG";
            string directoryPath2 = textBox1.Text;
            string fileName2 = "DISK3-UTILITY.IMG";
            string fullPath2 = Path.Combine(directoryPath2, fileName2);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win2, fullPath2);
            }

            string win3 = "https://github.com/breathemonoxide/diskimages/releases/download/1.01/DISK4-APPS.IMG";
            string directoryPath3 = textBox1.Text;
            string fileName3 = "DISK4-APPS.IMG";
            string fullPath3 = Path.Combine(directoryPath3, fileName3);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win3, fullPath3);
            }

            string win4 = "https://github.com/breathemonoxide/diskimages/releases/download/1.01/DISK5-WRITE.IMG";
            string directoryPath4 = textBox1.Text;
            string fileName4 = "DISK5-WRITE.IMG";
            string fullPath4 = Path.Combine(directoryPath4, fileName4);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win4, fullPath4);
            }
            MessageBox.Show("Download complete");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/1.02/DISK01.IMG";
            string directoryPath = textBox1.Text;
            string fileName = "DISK01.IMG";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/1.02/DISK02.IMG";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "DISK02.IMG";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/1.02/DISK03.IMG";
            string directoryPath2 = textBox1.Text;
            string fileName2 = "DISK03.IMG";
            string fullPath2 = Path.Combine(directoryPath2, fileName2);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win2, fullPath2);
            }

            string win3 = "https://github.com/breathemonoxide/diskimages/releases/download/1.02/DISK04.IMG";
            string directoryPath3 = textBox1.Text;
            string fileName3 = "DISK04.IMG";
            string fullPath3 = Path.Combine(directoryPath3, fileName3);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win3, fullPath3);
            }

            string win4 = "https://github.com/breathemonoxide/diskimages/releases/download/1.02/DISK05.IMG";
            string directoryPath4 = textBox1.Text;
            string fileName4 = "DISK05.IMG";
            string fullPath4 = Path.Combine(directoryPath4, fileName4);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win4, fullPath4);
            }

            string win5 = "https://github.com/breathemonoxide/diskimages/releases/download/1.02/DISK06.IMG";
            string directoryPath5 = textBox1.Text;
            string fileName5 = "DISK06.IMG";
            string fullPath5 = Path.Combine(directoryPath5, fileName5);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win5, fullPath5);
            }
            MessageBox.Show("Download complete");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string win = "https://github.com/breathemonoxide/diskimages/releases/download/1.03/D1_Setup.img";
            string directoryPath = textBox1.Text;
            string fileName = "D1_Setup.IMG";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/1.03/D2_Build.img";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "D2_Build.IMG";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/1.03/D3_Utils.img";
            string directoryPath2 = textBox1.Text;
            string fileName2 = "D3_Utils.IMG";
            string fullPath2 = Path.Combine(directoryPath2, fileName2);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win2, fullPath2);
            }

            string win3 = "https://github.com/breathemonoxide/diskimages/releases/download/1.03/D4_Font.img";
            string directoryPath3 = textBox1.Text;
            string fileName3 = "D4_Font.IMG";
            string fullPath3 = Path.Combine(directoryPath3, fileName3);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win3, fullPath3);
            }

            string win4 = "https://github.com/breathemonoxide/diskimages/releases/download/1.03/D5_Apps.img";
            string directoryPath4 = textBox1.Text;
            string fileName4 = "D5_Apps.IMG";
            string fullPath4 = Path.Combine(directoryPath4, fileName4);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win4, fullPath4);
            }

            string win5 = "https://github.com/breathemonoxide/diskimages/releases/download/1.03/D6_Write.img";
            string directoryPath5 = textBox1.Text;
            string fileName5 = "D6_Write.IMG";
            string fullPath5 = Path.Combine(directoryPath5, fileName5);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win5, fullPath5);
            }

            MessageBox.Show("Download complete");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/1.04/D1_Setup.img";
            string directoryPath = textBox1.Text;
            string fileName = "D1_Setup.IMG";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/1.04/D2_Build.img";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "D2_Build.IMG";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win3 = "https://github.com/breathemonoxide/diskimages/releases/download/1.04/D4_Font.img";
            string directoryPath3 = textBox1.Text;
            string fileName3 = "D4_Font.IMG";
            string fullPath3 = Path.Combine(directoryPath3, fileName3);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win3, fullPath3);
            }

            string win4 = "https://github.com/breathemonoxide/diskimages/releases/download/1.04/D5_Apps.img";
            string directoryPath4 = textBox1.Text;
            string fileName4 = "D5_Apps.IMG";
            string fullPath4 = Path.Combine(directoryPath4, fileName4);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win4, fullPath4);
            }

            string win5 = "https://github.com/breathemonoxide/diskimages/releases/download/1.04/D6_Write.img";
            string directoryPath5 = textBox1.Text;
            string fileName5 = "D6_Write.IMG";
            string fullPath5 = Path.Combine(directoryPath5, fileName5);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win5, fullPath5);
            }


            string win6 = "https://github.com/breathemonoxide/diskimages/releases/download/1.04/D7_Spdisk.img";
            string directoryPath6 = textBox1.Text;
            string fileName6 = "D7_Spdisk.IMG";
            string fullPath6 = Path.Combine(directoryPath6, fileName6);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win6, fullPath6);
            }

            MessageBox.Show("Download complete");

        }

        private void windows_1_Load(object sender, EventArgs e)
        {

        }
    }
}

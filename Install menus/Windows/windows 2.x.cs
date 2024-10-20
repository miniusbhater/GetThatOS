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

namespace GetThatOS.Install_menus.Windows
{
    public partial class windows_2 : Form
    {
        public windows_2()
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
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/2.03/disk1.img";
            string directoryPath = textBox1.Text;
            string fileName = "disk1.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/2.03/disk2.img";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "disk2.img";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/2.03/disk3.img";
            string directoryPath2 = textBox1.Text;
            string fileName2 = "disk3.img";
            string fullPath2 = Path.Combine(directoryPath2, fileName2);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win2, fullPath2);
            }

            string win3 = "https://github.com/breathemonoxide/diskimages/releases/download/2.03/disk4.img";
            string directoryPath3 = textBox1.Text;
            string fileName3 = "disk4.img";
            string fullPath3 = Path.Combine(directoryPath3, fileName3);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win3, fullPath3);
            }

            string win4 = "https://github.com/breathemonoxide/diskimages/releases/download/2.03/disk5.img";
            string directoryPath4 = textBox1.Text;
            string fileName4 = "disk5.img";
            string fullPath4 = Path.Combine(directoryPath4, fileName4);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win4, fullPath4);
            }

            MessageBox.Show("Download complete");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/286/disk01.img";
            string directoryPath = textBox1.Text;
            string fileName = "disk01.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }
            
            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/286/disk02.img";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "disk02.img";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/286/disk03.img";
            string directoryPath2 = textBox1.Text;
            string fileName2 = "disk03.img";
            string fullPath2 = Path.Combine(directoryPath2, fileName2);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win2, fullPath2);
            }

            string win3 = "https://github.com/breathemonoxide/diskimages/releases/download/286/disk04.img";
            string directoryPath3 = textBox1.Text;
            string fileName3 = "disk04.img";
            string fullPath3 = Path.Combine(directoryPath3, fileName3);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win3, fullPath3);
            }

            string win4 = "https://github.com/breathemonoxide/diskimages/releases/download/286/disk05.img";
            string directoryPath4 = textBox1.Text;
            string fileName4 = "disk05.img";
            string fullPath4 = Path.Combine(directoryPath4, fileName4);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win4, fullPath4);
            }

            string win5 = "https://github.com/breathemonoxide/diskimages/releases/download/286/disk06.img";
            string directoryPath5 = textBox1.Text;
            string fileName5 = "disk06.img";
            string fullPath5 = Path.Combine(directoryPath5, fileName5);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win5, fullPath5);
            }

            string win6 = "https://github.com/breathemonoxide/diskimages/releases/download/286/disk07.img";
            string directoryPath6 = textBox1.Text;
            string fileName6 = "disk07.img";
            string fullPath6 = Path.Combine(directoryPath6, fileName6);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win6, fullPath6);
            }

            MessageBox.Show("Download complete");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/386/Disk1.img";
            string directoryPath = textBox1.Text;
            string fileName = "Disk1.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/386/Disk2.img";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "Disk2.img";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/386/Disk3.img";
            string directoryPath2 = textBox1.Text;
            string fileName2 = "Disk3.img";
            string fullPath2 = Path.Combine(directoryPath2, fileName2);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win2, fullPath2);
            }

            string win3 = "https://github.com/breathemonoxide/diskimages/releases/download/386/Disk4.img";
            string directoryPath3 = textBox1.Text;
            string fileName3 = "Disk4.img";
            string fullPath3 = Path.Combine(directoryPath, fileName3);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win3, fullPath3);
            }

            MessageBox.Show("Download complete");
            
        }
    }
    }


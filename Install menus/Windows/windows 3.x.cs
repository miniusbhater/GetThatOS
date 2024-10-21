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
    public partial class windows_3 : Form
    {
        public windows_3()
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
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/3.0/DISK01.IMG";
            string directoryPath = textBox1.Text;
            string fileName = "disk01.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/3.0/DISK02.IMG";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "disk02.img";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win11 = "https://github.com/breathemonoxide/diskimages/releases/download/3.0/DISK03.IMG";
            string directoryPath11 = textBox1.Text;
            string fileName11 = "disk03.img";
            string fullPath11 = Path.Combine(directoryPath11, fileName11);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win11, fullPath11);
            }

            string win111 = "https://github.com/breathemonoxide/diskimages/releases/download/3.0/DISK04.IMG";
            string directoryPath111 = textBox1.Text;
            string fileName111 = "disk04.img";
            string fullPath111 = Path.Combine(directoryPath111, fileName111);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win111, fullPath111);
            }

            string win1111 = "https://github.com/breathemonoxide/diskimages/releases/download/3.0/DISK05.IMG";
            string directoryPath1111 = textBox1.Text;
            string fileName1111 = "disk05.img";
            string fullPath1111 = Path.Combine(directoryPath1111, fileName1111);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1111, fullPath1111);
            }

            MessageBox.Show("Download complete");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/3.1/Disk01.img";
            string directoryPath = textBox1.Text;
            string fileName = "disk01.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/3.1/Disk02.img";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "disk02.img";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win11 = "https://github.com/breathemonoxide/diskimages/releases/download/3.1/Disk03.img";
            string directoryPath11 = textBox1.Text;
            string fileName11 = "disk03.img";
            string fullPath11 = Path.Combine(directoryPath11, fileName11);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win11, fullPath11);
            }

            string win111 = "https://github.com/breathemonoxide/diskimages/releases/download/3.1/Disk04.img";
            string directoryPath111 = textBox1.Text;
            string fileName111 = "disk04.img";
            string fullPath111 = Path.Combine(directoryPath111, fileName111);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win111, fullPath111);
            }

            string win1111 = "https://github.com/breathemonoxide/diskimages/releases/download/3.1/Disk05.img";
            string directoryPath1111 = textBox1.Text;
            string fileName1111 = "disk05.img";
            string fullPath1111 = Path.Combine(directoryPath1111, fileName1111);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1111, fullPath1111);
            }

            string win11111 = "https://github.com/breathemonoxide/diskimages/releases/download/3.1/Disk06.img";
            string directoryPath11111 = textBox1.Text;
            string fileName11111 = "disk06.img";
            string fullPath11111 = Path.Combine(directoryPath11111, fileName11111);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win11111, fullPath11111);
            }

            MessageBox.Show("Download complete");

        }

        private void windows_3_Load(object sender, EventArgs e)
        {

        }
    }
}

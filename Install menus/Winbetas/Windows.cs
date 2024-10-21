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

namespace GetThatOS.Install_menus.Winbetas
{
    public partial class Windows : Form
    {
        public Windows()
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
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/DR5/disk01.img";
            string directoryPath = textBox1.Text;
            string fileName = "disk01.IMG";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/DR5/disk02.img";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "disk02.IMG";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/DR5/disk03.img";
            string directoryPath2 = textBox1.Text;
            string fileName2 = "disk03.IMG";
            string fullPath2 = Path.Combine(directoryPath2, fileName2);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win2, fullPath2);
            }

            MessageBox.Show("Download complete");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/alpha/Disk01.img";
            string directoryPath = textBox1.Text;
            string fileName = "Disk01.IMG";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/alpha/Disk02.img";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "Disk02.IMG";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/alpha/Disk03.img";
            string directoryPath2 = textBox1.Text;
            string fileName2 = "Disk03.IMG";
            string fullPath2 = Path.Combine(directoryPath2, fileName2);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win2, fullPath2);
            }

            string win3 = "https://github.com/breathemonoxide/diskimages/releases/download/alpha/Disk04.img";
            string directoryPath3 = textBox1.Text;
            string fileName3 = "Disk04.IMG";
            string fullPath3 = Path.Combine(directoryPath3, fileName3);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win3, fullPath3);
            }

            MessageBox.Show("Download complete");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/beta/Setup.img";
            string directoryPath = textBox1.Text;
            string fileName = "Setup.IMG";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/beta/Applications.img";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "Applications.IMG";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/beta/Utilities.img";
            string directoryPath2 = textBox1.Text;
            string fileName2 = "Utilities.IMG";
            string fullPath2 = Path.Combine(directoryPath2, fileName2);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win2, fullPath2);
            }

            MessageBox.Show("Download complete");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string win = "https://github.com/breathemonoxide/diskimages/releases/download/Premiere/disk01.img";
            string directoryPath = textBox1.Text;
            string fileName = "disk01.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win, fullPath);
            }

            string win1 = "https://github.com/breathemonoxide/diskimages/releases/download/Premiere/disk02.img";
            string directoryPath1 = textBox1.Text;
            string fileName1 = "disk02.img";
            string fullPath1 = Path.Combine(directoryPath1, fileName1);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win1, fullPath1);
            }

            string win2 = "https://github.com/breathemonoxide/diskimages/releases/download/Premiere/disk03.img";
            string directoryPath2 = textBox1.Text;
            string fileName2 = "disk03.img";
            string fullPath2 = Path.Combine(directoryPath2, fileName2);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win2, fullPath2);
            }

            string win3 = "https://github.com/breathemonoxide/diskimages/releases/download/Premiere/disk04.img";
            string directoryPath3 = textBox1.Text;
            string fileName3 = "disk04.img";
            string fullPath3 = Path.Combine(directoryPath3, fileName3);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(win3, fullPath3);
            }

            MessageBox.Show("Download complete");
        }

        private void Windows_Load(object sender, EventArgs e)
        {

        }
    }
}

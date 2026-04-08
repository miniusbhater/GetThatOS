using GetThatOS.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GetThatOS.Settings;
using System.IO;
using System.Diagnostics;

namespace GetThatOS.Main
{
    public partial class MainWindowMenu : Form
    {

        bool Windows11 = false;
        bool windows10 = false;
        bool windows81 = false;
        bool windows8 = false;
        bool windows7 = false;
        bool windowsvista = false;
        bool windowsxp = false;
        bool windowsme = false;
        bool windows2000 = false;
        bool windows98 = false;
        bool windows95 = false;
        bool windows31 = false;
        bool windows3 = false;
        bool windows2 = false;
        bool windows = false;
        bool macos15 = false;
        bool macos14 = false;
        bool macos13 = false;
        bool macos12 = false;
        bool macos11 = false;
        bool macos10_15 = false;
        bool macos10_14 = false;
        bool macos10_13 = false;
        bool macos10_12 = false;
        bool macos10_11 = false;
        bool macos10_10 = false;
        bool macos10_9 = false;
        bool macos10_8 = false;
        bool macos10_7 = false;
        bool macos10_6 = false;
        bool macos10_5 = false;
        bool macos10_4 = false;
        bool macos10_3 = false;
        bool macos10_2 = false;
        bool macos10_1 = false;
        bool macos10_0 = false;
        bool macos9 = false;
        bool macos8 = false;
        bool macos7 = false;
        bool macos6 = false;
        bool macos5 = false;
        bool macos4 = false;
        bool macos3 = false;
        bool macos2 = false;
        bool macos = false;        
        public MainWindowMenu()
        {
            Console.WriteLine("GetThatOS");
            Console.WriteLine("0.2.9");
            InitializeComponent();


        }



        public void MainWindowMenu_Load(object sender, EventArgs e)
        {
            IntitiallyUpdateLogo();
            DisableUnwantedText();
            DisableUnwantedButtons();
            GetDocs();
            string osEnv = System.Environment.OSVersion.ToString();
            this.Text = $"GetThatOS 0.2.9 | {osEnv}";

        }

        public void GetDocs()
        {
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fulldocs = Path.Combine(docs, "GetThatOSImages");
            Directory.CreateDirectory(fulldocs);
            textBox1.Text = fulldocs;
        }

        public async void IntitiallyUpdateLogo()
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "GetThatOS_logo.ico");
            try
            {
                pictureBox1.Image = Image.FromFile(imgpath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something bad happened! :(");
            }
        }

        public void DisableUnwantedText()
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;

        }

        public void DisableUnwantedPanels()
        {
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel2.Enabled = false;
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel3.Enabled = false;
        }

        public void DisableUnwantedButtons()
        {

            button11.Enabled = false;
            button11.Visible = false;
            button12.Enabled = false;
            button12.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows11_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Visible = true;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            UUPDumpInfo UUPDumpInfo = new UUPDumpInfo();
            UUPDumpInfo.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows11_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Visible = true;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel2.Enabled = true;
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel3.Enabled = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows11_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n      11";
            label8.Visible = true;
            button11.Enabled = true;
            button11.Visible = true;
            button12.Enabled = true;
            button12.Visible = true;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
            Windows11 = true;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows10_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n      10";
            label8.Visible = true;
            button11.Enabled = true;
            button11.Visible = true;
            button12.Enabled = true;
            button12.Visible = true;
            Windows11 = false;
            windows10 = true;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows8_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n      8.1";
            button12.Enabled = true;
            button12.Visible = true;
            Windows11 = false;
            windows10 = false;
            windows81 = true;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "LinuxTux_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            button11.Enabled = false;
            button11.Visible = false;
            button12.Enabled = false;
            button12.Visible = false;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel2.Enabled = false;
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel3.Enabled = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacModern_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            button11.Enabled = false;
            button11.Visible = false;
            button12.Enabled = false;
            button12.Visible = false;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel2.Enabled = false;
            flowLayoutPanel3.Visible = true;
            flowLayoutPanel3.Enabled = true;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
            button12.Visible = true;
            button12.Enabled = true;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "GetThatOSOther_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            button11.Enabled = false;
            button11.Visible = false;
            button12.Enabled = false;
            button12.Visible = false;
            flowLayoutPanel2.Visible = false;
            flowLayoutPanel2.Enabled = false;
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel3.Enabled = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows8_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n       8";
            button12.Enabled = true;
            button12.Visible = true;
            label8.Visible = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = true;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows7_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n       7";
            button12.Enabled = true;
            button12.Visible = true;
            label8.Visible = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = true;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "WindowsVista_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n    Vista";
            button12.Enabled = true;
            button12.Visible = true;
            label8.Visible = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = true;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "WindowsXP_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n      XP";
            button12.Enabled = true;
            button12.Visible = true;
            label8.Visible = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = true;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "WindowsME_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n      ME";
            button12.Enabled = true;
            button12.Visible = true;
            label8.Visible = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = true;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows2000_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n    2000";
            button12.Enabled = true;
            button12.Visible = true;
            label8.Visible = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = true;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows98953_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n      98";
            button12.Enabled = true;
            button12.Visible = true;
            label8.Visible = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = true;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows98953_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n      95";
            button12.Enabled = true;
            button12.Visible = true;
            label8.Visible = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = true;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows98953_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n      3.1";
            button12.Enabled = true;
            button12.Visible = true;
            label8.Visible = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = true;
            windows3 = false;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows98953_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n       3";
            button12.Enabled = true;
            button12.Visible = true;
            label8.Visible = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = true;
            windows2 = false;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows\n       2";
            button12.Enabled = true;
            button12.Visible = true;
            label8.Visible = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = true;
            windows = false;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "Windows_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label3.Text = "Windows";
            button12.Enabled = true;
            button12.Visible = true;
            label8.Visible = false;
            Windows11 = false;
            windows10 = false;
            windows81 = false;
            windows8 = false;
            windows7 = false;
            windowsvista = false;
            windowsxp = false;
            windowsme = false;
            windows2000 = false;
            windows98 = false;
            windows95 = false;
            windows31 = false;
            windows3 = false;
            windows2 = false;
            windows = true;
            button10.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Windows11)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://archive.org/download/windows-11-24h2-iso_202501/Win11_24H2_English_x64.iso", Path.Combine(directory, "Windows11.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (windows10)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://archive.org/download/en-us_windows_10_consumer_editions_version_22h2_updated_feb_2023_x64_dvd_c29e4bb3/en-us_windows_10_consumer_editions_version_22h2_updated_feb_2023_x64_dvd_c29e4bb3.iso", Path.Combine(directory, "Windows10.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (windows81)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://archive.org/download/win-8.1-english-x-64-x-86/Win8.1_English_x64.iso", Path.Combine(directory, "Windows8-1.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (windows8)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://archive.org/download/windows-8-x-64/Windows%208%20x64.iso", Path.Combine(directory, "Windows8.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (windows7)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://archive.org/download/Windows7-iso/win7_64_bit.iso", Path.Combine(directory, "Windows7.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (windowsvista)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://archive.org/download/windows-vista-64bit_202303/Windows_Vista_64bit.iso", Path.Combine(directory, "WindowsVista.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (windowsxp)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://archive.org/download/WinXPProSP3x86/en_windows_xp_professional_with_service_pack_3_x86_cd_vl_x14-73974.iso", Path.Combine(directory, "WindowsXP.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (windowsme)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/me/Windows.Me.115.-.OEM.Full.iso", Path.Combine(directory, "WindowsME.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (windows2000)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/2k/5.00.2195.1_x86fre_Professional_en-us-W2PFPP_EN.iso", Path.Combine(directory, "Win2k.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (windows98)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/98/Windows.98.Second.Edition.iso", Path.Combine(directory, "Windows.98.Second.Edition.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (windows95)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/95/windows95b.iso", Path.Combine(directory, "windows95.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (windows31)
            {
                string directory = textBox1.Text;

                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk01.img", Path.Combine(directory, "disk01.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk02.img", Path.Combine(directory, "disk02.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk03.img", Path.Combine(directory, "disk03.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk04.img", Path.Combine(directory, "disk04.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk05.img", Path.Combine(directory, "disk05.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3.1/Disk06.img", Path.Combine(directory, "disk06.img"), () =>
                {
                    MessageBox.Show("Download complete");
                }))))));
            }

            if (windows3)
            {
                string directory = textBox1.Text;

                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3.0/DISK01.IMG", Path.Combine(directory, "disk01.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3.0/DISK02.IMG", Path.Combine(directory, "disk02.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3.0/DISK03.IMG", Path.Combine(directory, "disk03.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3.0/DISK04.IMG", Path.Combine(directory, "disk04.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3.0/DISK05.IMG", Path.Combine(directory, "disk05.img"), () =>
                {
                    MessageBox.Show("Download complete");
                })))));
            }

            if (windows2)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/2.03/disk1.img", Path.Combine(directory, "disk1.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/2.03/disk2.img", Path.Combine(directory, "disk2.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/2.03/disk3.img", Path.Combine(directory, "disk3.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/2.03/disk4.img", Path.Combine(directory, "disk4.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/2.03/disk5.img", Path.Combine(directory, "disk5.img"), () =>
                {
                    MessageBox.Show("Download complete");
                })))));

            }

            if (windows)
            {
                string directory = textBox1.Text;

                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/1.03/D1_Setup.img", Path.Combine(directory, "D1_Setup.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/1.03/D2_Build.img", Path.Combine(directory, "D2_Build.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/1.03/D3_Utils.img", Path.Combine(directory, "D3_Utils.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/1.03/D4_Font.img", Path.Combine(directory, "D4_Font.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/1.03/D5_Apps.img", Path.Combine(directory, "D5_Apps.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/1.03/D6_Write.img", Path.Combine(directory, "D6_Write.img"), () =>
                {
                    MessageBox.Show("Download complete");
                }))))));

            }

            if (macos15)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://swcdn.apple.com/content/downloads/22/06/047-96175-A_196UW6QK9G/dx1bmt6mb0q3llh0iyingau9ld5liod96r/InstallAssistant.pkg", Path.Combine(directory, "InstallAssistant.pkg15.dmg"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos14)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://swcdn.apple.com/content/downloads/23/16/047-96015-A_F2ZJ8P7940/aknn1yshpkeeg1l3hgz7saai1d0zguw31y/InstallAssistant.pkg", Path.Combine(directory, "InstallAssistant.pkg14.dmg"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos13)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://swcdn.apple.com/content/downloads/09/46/093-22004-A_QNZEDC334I/phigx2zvoggml6sh79my4y51fnvgy8hix4/InstallAssistant.pkg", Path.Combine(directory, "InstallAssistant.pkg13.dmg"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos12)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://swcdn.apple.com/content/downloads/46/57/052-60131-A_KM2RH04C2D/9yzvba1uvpem2wuo95r459qno57qaizwf2/InstallAssistant.pkg", Path.Combine(directory, "InstallAssistant.pkg12.dmg"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos11)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("http://swcdn.apple.com/content/downloads/14/38/042-45246-A_NLFOFLCJFZ/jk992zbv98sdzz3rgc7mrccjl3l22ruk1c/InstallAssistant.pkg", Path.Combine(directory, "InstallAssistant.pkg11.dmg"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos10_15)
            {
                string downl = "https://apps.apple.com/us/app/macos-catalina/id1466841314?mt=12";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = downl,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }

            if (macos10_14)
            {
                string downl = "https://apps.apple.com/us/app/macos-mojave/id1398502828?mt=12";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = downl,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }

            if (macos10_13)
            {
                string downl = "https://itunes.apple.com/us/app/macos-high-sierra/id1246284741";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = downl,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }

            if (macos10_12)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("http://updates-http.cdn-apple.com/2019/cert/061-39476-20191023-48f365f4-0015-4c41-9f44-39d3d2aca067/InstallOS.dmg", Path.Combine(directory, "InstallMacOSX10.12.dmg"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos10_11)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("http://updates-http.cdn-apple.com/2019/cert/061-41424-20191024-218af9ec-cf50-4516-9011-228c78eda3d2/InstallMacOSX.dmg", Path.Combine(directory, "InstallMacOSX10.11.dmg"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos10_10)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("http://updates-http.cdn-apple.com/2019/cert/061-41343-20191023-02465f92-3ab5-4c92-bfe2-b725447a070d/InstallMacOSX.dmg", Path.Combine(directory, "InstallMacOSX10.10.dmg"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos10_9)
            {
                string downl = "https://archive.org/details/os-x-mavericks-10.9.5";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = downl,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }

            if (macos10_8)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://updates.cdn-apple.com/2021/macos/031-0627-20210614-90D11F33-1A65-42DD-BBEA-E1D9F43A6B3F/InstallMacOSX.dmg", Path.Combine(directory, "InstallMacOSX10.8.dmg"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos10_7)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://updates.cdn-apple.com/2021/macos/041-7683-20210614-E610947E-C7CE-46EB-8860-D26D71F0D3EA/InstallMacOSX.dmg", Path.Combine(directory, "InstallMacOSX10.7.dmg"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos10_6)
            {
                string downl = "https://archive.org/details/mac-os-x-10.6-snow-leopard-retail";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = downl,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }

            if (macos10_5)
            {
                string downl = "https://archive.org/details/OsxLeopardInstall";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = downl,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }

            if (macos10_4)
            {
                string downl = "https://archive.org/details/mac-os-x-tiger-intelppc";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = downl,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }

            if (macos10_3)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.1.iso", Path.Combine(directory, "osx-10.3.disk1.iso"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.2.iso", Path.Combine(directory, "osx-10.3.disk2.iso"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.3.iso", Path.Combine(directory, "osx-10.3.disk3.iso"), () =>
                {
                    MessageBox.Show("Download complete");
                })));
            }

            if (macos10_2)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/10.2/disk1.iso", Path.Combine(directory, "osx-10.2.disk1.iso"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/10.2/disk2.iso", Path.Combine(directory, "osx-10.2.disk2.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                }));
            }

            if (macos10_1)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/10.1/osx_101_5g64_install.iso", Path.Combine(directory, "osx-10.1.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos10_0)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/osx10.0/osx-10.0.iso", Path.Combine(directory, "osx-10.0.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos9)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/9.2/macos_921_ppc.iso", Path.Combine(directory, "macos_921_ppc.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos8)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/8.0/Apple.MacOS.8.0.m68k.iso", Path.Combine(directory, "Apple.MacOS.8.0.m68k.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos7)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/7/System.7.1.CD.iso", Path.Combine(directory, "System.7.1.CD.iso"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos6)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/6/Printing.Tools.img", Path.Combine(directory, "Printing.Tools.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/6/System.Tools.img", Path.Combine(directory, "System.Tools.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/6/Utilities.1.img", Path.Combine(directory, "Utilities.1.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/6/Utilities.2.img", Path.Combine(directory, "Utilities.2.img"), () =>
                {
                    MessageBox.Show("Download complete");
                }))));
            }

            if (macos5)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/5.0/System.Tools.1.img", Path.Combine(directory, "System.Tools.1.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/5.0/System.Tools.2.img", Path.Combine(directory, "System.Tools.2.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/5.0/Utilities.1.img", Path.Combine(directory, "Utilities.1.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/5.0/Utilities.2.img", Path.Combine(directory, "Utilities.2.img"), () =>
                {
                    MessageBox.Show("Download complete");
                }))));
            }

            if (macos4)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/4/System.Tools.2.0.1.img", Path.Combine(directory, "System.Tools.2.0.1.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/4/Utilities.2.1.Disk.1.img", Path.Combine(directory, "Utilities.2.1.Disk.1.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/4/Utilities.2.1.Disk.2.img", Path.Combine(directory, "Utilities.2.1.Disk.2.img"), () =>
                {
                    MessageBox.Show("Download complete");
                })));
            }

            if (macos3)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3/System.Tools.512ke.v1.0.img", Path.Combine(directory, "System.Tools.512ke.v1.0.img"), () =>
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/3/Utilities.1.0.img", Path.Combine(directory, "Utilities.1.0.img"), () =>

                {
                    MessageBox.Show("Download complete");
                }));
            }

            if (macos2)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/sys2/System.Disk.img", Path.Combine(directory, "System.Disk.System.Software.2.img"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }

            if (macos)
            {
                string directory = textBox1.Text;
                DownloadFileWithProgress("https://github.com/miniusbhater/diskimages/releases/download/sys1/System.Disk.img", Path.Combine(directory, "System.Disk.img"), () =>

                {
                    MessageBox.Show("Download complete");
                });
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            SettingsWindow settings = new SettingsWindow();
            settings.Show();
        }

        private void DownloadFileWithProgress(string url, string path, Action completed)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += (s, e) =>
            {
                progressBar1.Value = e.ProgressPercentage;
            };

            client.DownloadFileCompleted += (s, e) =>
            {
                client.Dispose();
                completed?.Invoke();
            };

            client.DownloadFileAsync(new Uri(url), path);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacModern_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS 15";
            label2.Visible = false;
            macos15 = true;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;

        }

        private void button25_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacModern_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS 14";
            label2.Visible = false;
            macos15 = false;
            macos14 = true;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;

        }

        private void button26_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacModern_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS 13";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = true;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;

        }

        private void button27_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacModern_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS 12";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = true;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacModern_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS 11";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = true;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacFlat_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n 10.15";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = true;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacFlat_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n 10.14";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = true;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacFlat_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n 10.13";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = true;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacFlat_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n 10.12";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = true;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacFlat_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n 10.11";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = true;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacFlat_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n 10.10";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = true;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n  10.9";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = true;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n  10.8";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = true;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n  10.7";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = true;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n  10.6";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = true;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n  10.5";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = true;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n  10.4";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = true;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n  10.3";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = true;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n  10.2";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = true;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n  10.1";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = true;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n  10.0";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = true;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacPreOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n     9";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = true;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacPreOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n     8";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = true;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacPreOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "MacOS\n     7";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = true;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacPreOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "System\n     6";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = true;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacPreOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "System\n     5";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = true;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacPreOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "System\n     4";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = true;
            macos3 = false;
            macos2 = false;
            macos = false;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacPreOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "System\n     3";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = true;
            macos2 = false;
            macos = false;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacPreOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "System\n     2";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = true;
            macos = false;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            string img = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string imgpath = Path.Combine(img, "GetThatOS", "LogosAndImages", "MacPreOSX_logo.ico");
            pictureBox1.Image = Image.FromFile(imgpath);
            label5.Visible = true;
            label5.Text = "System\n     1";
            label2.Visible = false;
            macos15 = false;
            macos14 = false;
            macos13 = false;
            macos12 = false;
            macos11 = false;
            macos10_15 = false;
            macos10_14 = false;
            macos10_13 = false;
            macos10_12 = false;
            macos10_11 = false;
            macos10_10 = false;
            macos10_9 = false;
            macos10_8 = false;
            macos10_7 = false;
            macos10_6 = false;
            macos10_5 = false;
            macos10_4 = false;
            macos10_3 = false;
            macos10_2 = false;
            macos10_1 = false;
            macos10_0 = false;
            macos9 = false;
            macos8 = false;
            macos7 = false;
            macos6 = false;
            macos5 = false;
            macos4 = false;
            macos3 = false;
            macos2 = false;
            macos = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Sierra form = new Sierra();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

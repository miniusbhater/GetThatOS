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

namespace GetThatOS.Settings
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.OpenRepo.Repo();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\GetThatIntegrity.exe";
            Process.Start(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://discord.gg/4ZnDNuAWma", UseShellExecute = true });
        }
    }
}

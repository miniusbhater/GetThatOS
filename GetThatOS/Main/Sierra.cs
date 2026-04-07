using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Diagnostics;

namespace GetThatOS.Main
{
    public partial class Sierra : Form
    {
        public Sierra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string download20 = "https://github.com/miniusbhater/SierraOS/releases/latest/download/SierraOS.iso";
            string directory = textBox1.Text;
            string output20 = Path.Combine(directory, "SierraOS.iso");

            using (WebClient webclient20 = new WebClient())
            {
                webclient20.DownloadFile(new Uri(download20), output20);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sierra_Load(object sender, EventArgs e)
        {
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fulldocs = Path.Combine(docs, "GetThatOSImages");
            Directory.CreateDirectory(fulldocs);
            textBox1.Text = fulldocs;
        }
    }
}

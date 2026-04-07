using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetThatOS.Info
{
    public partial class UUPDumpInfo : Form
    {
        public UUPDumpInfo()
        {
            InitializeComponent();
        }
        public void UUPDumpInfo_Load(object sender, EventArgs e)
        {
            

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://uupdump.net/"; // Stuff for opening UUP Dump
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

    }
}

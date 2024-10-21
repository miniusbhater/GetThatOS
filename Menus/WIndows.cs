using GetThatOS.Install_menus.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetThatOS
{
    public partial class WIndows : Form
    {
        public WIndows()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           windows_1 win1 = new windows_1();
            win1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            windows_2 windows_2 = new windows_2();  
            windows_2.Show();
        }

        private void WIndows_Load(object sender, EventArgs e)
        {

        }
    }
}

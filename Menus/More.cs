using GetThatOS.Install_menus.TempleOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetThatOS.Menus
{
    public partial class More : Form
    {
        public More()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MS_Dos dos = new MS_Dos();
            dos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassicMacOS classmac = new ClassicMacOS();
            classmac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Winbetas winbetas = new Winbetas();
            winbetas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            winserver winserver = new winserver();
            winserver.Show();
        }

        private void More_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tos tos = new tos();
            tos.Show();
        }
    }
}

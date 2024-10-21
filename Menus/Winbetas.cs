using GetThatOS.Install_menus.Winbetas;
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
    public partial class Winbetas : Form
    {
        public Winbetas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Windows windows = new Windows();
            windows.Show();
        }

        private void Winbetas_Load(object sender, EventArgs e)
        {

        }
    }
}

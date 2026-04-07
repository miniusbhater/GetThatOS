using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//unused
namespace GetThatOS.Main
{
    public partial class Initialize : Form
    {
        public Initialize()
        {
            Main.FirstTimeRun.msg();
            InitializeComponent();
        }

        private void Initialize_Load(object sender, EventArgs e)
        {
            
        }
    }
}

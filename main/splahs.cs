using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetThatOS.main
{
    public partial class splahs : Form
    {

        public static splahs Instance { get; private set; }
        public splahs()
        {
            InitializeComponent();
            this.Shown += async (sender, e) =>
            {
         
                await Task.Delay(100);


                RunAfterRender();
            };
        }

        private void RunAfterRender()
        {
            Thread.Sleep(4500);
            GetThatOS getos = new GetThatOS();
            getos.Show();
            this.Hide();
        }

        private void splahs_Load(object sender, EventArgs e)
        {

        }

        private void splahs_Load_1(object sender, EventArgs e)
        {

        }
    }

    
    }


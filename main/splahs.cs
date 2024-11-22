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
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace GetThatOS.main
{
    public partial class splahs : Form
    {



    






            public static splahs Instance { get; private set; }
        public splahs()
        {
            InitializeComponent();
            Thread.Sleep(750);
            this.Shown += async (sender, e) =>
            {
         
                await Task.Delay(100);


                RunAfterRender();
            };
        }

        private void RunAfterRender()
        {
            string fileName = "GetThatOSUpdater.exe";
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, fileName);

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    Console.WriteLine($"{fileName} has been successfully deleted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while deleting the updater: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"{fileName} does not exist in the current directory.");
            }

            
            Thread.Sleep(4500);
            GetThatOS getos = new GetThatOS();
            this.Hide();
            Thread.Sleep(400);
            getos.Show();
            
        }

        private void splahs_Load(object sender, EventArgs e)
        {

        }

        private void splahs_Load_1(object sender, EventArgs e)
        {

        }
    }

    
    }


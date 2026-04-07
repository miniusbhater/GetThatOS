using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetThatOS.Main
{
    //unused
    public class FirstTimeRun
    {
        public static void check()
        {
            //Checks if GetThatOS has been run before
            string HasRun = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GetThatOS", "HasRun.GTOS");
            if (File.Exists(HasRun))
            {
                Console.WriteLine("GetThatOS Has Been Run Before");
                Main.FullFunc.Check();
            }
            else
            {
                Console.WriteLine("GetThatOS Has Not Been Run Before, Prompting.");
                msg();
            }
        }
        public static void msg()
{
            //Prompts the user to create the appdata files
            DialogResult MakeFiles = MessageBox.Show("Thanks for downloading GetThatOS!\nIn order to use this software, I must make some files in AppData.\nWould you like to continue?", "GetThatOS by miniusbhater", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MakeFiles == DialogResult.Yes)
            {
                string AppData;
                AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string CreationFolder;
                CreationFolder = Path.Combine(AppData, "GetThatOS");
                Directory.CreateDirectory(CreationFolder);
                Console.WriteLine("Folder Created");
                string CreationFile = Path.Combine(CreationFolder, "HasRun.GTOS");
                File.WriteAllText(CreationFile, "GetThatOS has completed folder creation!\nhttps://github.com/miniusbhater/GetThatOS");
                Console.WriteLine("File Created");
                Main.FullFunc.FullFuncmsg();
            }
            else
            {
                Environment.Exit(1);
                Console.WriteLine("Denied folder creation");
                Console.WriteLine("Exiting with code 1");
            }
        }

    }
}

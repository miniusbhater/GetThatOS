using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetThatOS.Main
{
    //unused
    internal class FullFunc
    {
        public static void Check()
        {
            //Checks if GetThatOS has been run before
            string HasRun = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GetThatOS", "Resources");
            if (File.Exists(HasRun))
            {
                Console.WriteLine("GetThatOS Has It's Resources");
                MainWindowMenu main = new MainWindowMenu();   
                main.Show();
                
            }
            else
            {
                Console.WriteLine("Prompting.");
                FullFuncmsg();
            }
        }
        public static void FullFuncmsg()
        {



            DialogResult ExtraDown = MessageBox.Show("GetThatOS has detected that it needs to download some extra files to AppData\nWould you like to continue?", "GetThatOS by miniusbhater", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ExtraDown == DialogResult.Yes)
            {
               
                downextra();
            }
            else
            {
                Environment.Exit(1);
                Console.WriteLine("Denied extra appdata");
                Console.WriteLine("Exiting with code 1");
            }
        }

        private static void downextra()
        {
            string AppData;
            AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string CreationFolder;
            CreationFolder = Path.Combine(AppData, "GetThatOS", "Resources");
            Directory.CreateDirectory(CreationFolder);
            Console.WriteLine("Folder Created");          
            string Download = "https://raw.githubusercontent.com/miniusbhater/GetThatOS/main/GetThatOS%20Resources/GetThatOS_logo.png";
            string Direc = CreationFolder;
            string File = "GetThatOS_logo.png";
            string Full = Path.Combine(Direc, File);

            using (WebClient webclient = new WebClient())
            {
                webclient.DownloadFile(new Uri(Direc), Full);
            }
        }
    }
}
    


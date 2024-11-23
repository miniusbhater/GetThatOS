
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Threading;
using System.IO;


class GetThatOSRemove
{
    static void Main()
    {
    
        Console.WriteLine("V1.0.0");
        Thread.Sleep(300);
        Console.WriteLine("THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR\r\nIMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,\r\nFITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE\r\nAUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER\r\nLIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,\r\nOUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\r\nSOFTWARE.");
        Thread.Sleep(1000);
        Console.WriteLine("\n \n \nDo you want to remove GetThatOS from your system? (y/n)");

        string? input = Console.ReadLine()?.ToLower();

        if (input == "y")
        {

            string getosname = "GetThatOS.exe";
            string getos = AppDomain.CurrentDomain.BaseDirectory;
            string getosfull = Path.Combine(getos, getosname);

            if (File.Exists(getosfull))
            {
                Thread.Sleep(434);
                Console.WriteLine("Removing GetThatOS please wait...");

                Thread.Sleep(421);

                string processName = "GetThatOS";
                Process[] processes = Process.GetProcessesByName(processName);

                foreach (Process process in processes)
                {
                    process.Kill();
                }

                string getosname1 = "GetThatOS.exe";
                string getos1 = AppDomain.CurrentDomain.BaseDirectory;
                string getosfull1 = Path.Combine(getos1, getosname1);
                File.Delete(getosfull1);
            }

            else
            {
                Console.WriteLine("Error (1)! could not find GetThatOS. Exiting...");
                Thread.Sleep(1200);
                Environment.Exit(1);
            }

            string getosname3 = "GetThatOSUpdater.exe";
            string getos3 = AppDomain.CurrentDomain.BaseDirectory;
            string getosfull3 = Path.Combine(getos3, getosname3);

            if (File.Exists(getosfull3))
            {
                Thread.Sleep(640);
                Console.WriteLine("Removing Updater please wait...");

                Thread.Sleep(640);

                string processName = "GetThatOSUpdater";
                Process[] processes = Process.GetProcessesByName(processName);

                foreach (Process process in processes)
                {
                    process.Kill();
                }

                string getosname4 = "GetThatOSUpdater.exe";
                string getos4 = AppDomain.CurrentDomain.BaseDirectory;
                string getosfull4 = Path.Combine(getos4, getosname4);
                File.Delete(getosfull4);
            }

            else
            {
                Console.WriteLine("Error (3)! could not find GetThatOSUpdater. Press any key to continue");
                Console.ReadKey();
            }

            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolderPath = Path.Combine(appDataFolder, "GetThatOS");
            Thread.Sleep(150);
            Console.WriteLine("Removing AppData...");
            Thread.Sleep(150);
            if (Directory.Exists(appFolderPath))
            {
                try
                {
                    Directory.Delete(appFolderPath, true);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting GetThatOS appdata: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("GetThatOS appdata does not exist! Press any key to continue");
                Console.ReadKey();
            }

            {
                Thread.Sleep(900);
                Console.WriteLine("Removal Complete! Press any key to close...");
                Console.ReadKey();

                string currentExePath = Process.GetCurrentProcess().MainModule?.FileName;

                if (currentExePath != null)
                {
                    string tempBatchFile = Path.Combine(Path.GetTempPath(), "deleteSelf.bat");

                    File.WriteAllText(tempBatchFile, $@"
@echo off
timeout /t 2 >nul
del ""{currentExePath}""
del ""%~f0""");

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = tempBatchFile,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden
                    });

                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Error! Unable to delete the Remover, you will have to manually delete it. Press any key to exit");
                    Console.ReadKey();
                    Thread.Sleep(300);
                    Environment.Exit(4);
                }
            }

        } 









            else if (input == "n")
            {
                Console.WriteLine("Would you like to start up GetThatOS? (y/n)");
                string? input2 = Console.ReadLine()?.ToLower();
                if (input2 == "y")
                {

                    string getosname2 = "GetThatOS.exe";
                    string getos2 = AppDomain.CurrentDomain.BaseDirectory;
                    string getosfull2 = Path.Combine(getos2, getosname2);

                    if (File.Exists(getosfull2))
                    {
                        Console.WriteLine("Starting GetThatOS...");
                        Thread.Sleep(1500);

                        System.Diagnostics.Process.Start(getosfull2);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Error (1)! could not find GetThatOS. Exiting...");
                        Thread.Sleep(1200);
                        Environment.Exit(1);
                    }
                }

                else if (input2 == "n")

                    Console.WriteLine("Okay! now exiting...");
                Thread.Sleep(1200);
                Environment.Exit(0);
            }




            else
            {
                Console.WriteLine("Invalid input (2)! Exiting...");
                Thread.Sleep(1200);
                Environment.Exit(2);

            }
        }
    }





using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GetThatOSCLI.loader
{
    internal class loader
    {
        public static async Task beginLoad()
        {
            await printGOS();
            await getVersion();
            await getArch();
            await operatingSystem();
            await beginGOS();
            await adminWarn();
            await onlineCheck();      
            await githubCheck();
            await appleCheck();
            await updateCheck();
            await loadMenu();
        }

        static async Task printGOS()
        {
            Console.WriteLine("GetThatOS");
        }
        static async Task getVersion()
        {
            Version ver = Assembly.GetExecutingAssembly().GetName().Version;
            Console.WriteLine($"{ver}");
        }

        static async Task getArch()
        {
            string procArch;
            procArch = RuntimeInformation.ProcessArchitecture.ToString();
            string osArch;
            osArch = RuntimeInformation.OSArchitecture.ToString();
            Console.WriteLine($"Process is {procArch}");
            Console.WriteLine($"OS is {osArch}");
        }

        static async Task operatingSystem()
        {
            string OS;
            OS = System.Environment.OSVersion.ToString();
            Console.WriteLine($"{OS}");
        }
      

        static async Task beginGOS()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to GetThatOS!");
            Console.ForegroundColor= ConsoleColor.White;
        }

        static async Task adminWarn()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("On Windows, running with admin permissions may be required\ndepending on the folder you download disk images to");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static async Task onlineCheck()
        {            
            try
            {
                var google = "www.google.com";
                Ping ping = new Ping();
                PingReply response = await ping.SendPingAsync(google);

                if (response.Status == IPStatus.Success)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Online");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Offline");
                }

                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unable to attempt to ping google due to:");
                Console.WriteLine($"{ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        static async Task githubCheck()
        {
            try
            {
                var google = "www.github.com";
                Ping ping = new Ping();
                PingReply response = await ping.SendPingAsync(google);

                if (response.Status == IPStatus.Success)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GitHub Online");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("GitHub Offline some downloads may fail!");
                }

                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unable to attempt to ping GitHub due to:");
                Console.WriteLine($"{ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static async Task appleCheck()
        {
            try
            {
                var google = "www.apple.com";
                Ping ping = new Ping();
                PingReply response = await ping.SendPingAsync(google);

                if (response.Status == IPStatus.Success)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Apple Online");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Apple Offline some downloads may fail!");
                }

                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unable to attempt to ping Apple due to:");
                Console.WriteLine($"{ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static async Task updateCheck()
        {
            Console.WriteLine("Checking for updates...");
            Version currentVer = Assembly.GetExecutingAssembly().GetName().Version;
            Version currentVersion = currentVer;

            try
            {
                using HttpClient httpclient = new HttpClient();
                string gist = $"https://gist.githubusercontent.com/miniusbhater/6df05eab2c8e3e8b0d695d6b3d4a1437/raw/gistfile1.txt?nocache={Guid.NewGuid()}";
                string versionContent = await httpclient.GetStringAsync(gist);
                if (Version.TryParse(versionContent.Trim(), out Version latestVersion))
                {
                    Console.WriteLine($"Latest version: {latestVersion}");

                    if (latestVersion > currentVersion)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Update available!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Updating is only supported on Windows\nIf you are not using windows please select no");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(200);
                        Console.WriteLine($"Current version: {currentVersion}\nNew version: {latestVersion}\nWould you like to update now? (y/n)");                      
                        while (true)
                        {
                            var keyInfo = Console.ReadKey(intercept: true);

                            if (keyInfo.Key == ConsoleKey.Y)
                            {
                                Console.WriteLine("Please wait...");
                                Thread.Sleep(200);
                                await loadUpdater();
                                break;

                            }
                            else if (keyInfo.Key == ConsoleKey.N)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("GetThatOS will not be updated");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("GetThatOS will not be updated");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                        }
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("GetThatOS is up-to-date!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor  = ConsoleColor.Red;
                    Console.WriteLine("Couldn't check for updates!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Couldn't check for updates!: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }      
        }



        static async Task loadUpdater()
        {
            update.updater.clearConsole();
            Console.ReadKey();
        }

        static async Task loadMenu()
        {
            main.mainMenu.menu();
        }

    }
}

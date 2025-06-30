using GetThatOSCLI.main;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace GetThatOSCLI.downloader
{
    internal class downloader
    {

        //-------------------------------------------------------------Mac----------------------------------------------------------------------------------

        public static void tahoe()
        {
            string url = "https://swcdn.apple.com/content/downloads/48/60/082-62552-A_EMRHUZQE63/olsval9x51g10i8oplpeakcon8gqp1agei/InstallAssistant.pkg";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallAssistantTahoe.pkg";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
            else
            {
                Console.WriteLine("Download incomplete.");
            }
        }

        public static void sequoia()
        {
            string url = "https://swcdn.apple.com/content/downloads/51/28/082-44432-A_4NJSZXK8G5/v10fo5dlwd50fja3qbnhj7z9tp1dx41vq2/InstallAssistant.pkg";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallAssistantSequoia.pkg";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
            else
            {
                Console.WriteLine("Download incomplete.");
            }
        }

        public static void sonoma()
        {
            string url = "https://swcdn.apple.com/content/downloads/53/29/082-42388-A_LTM5K4K83B/kzw5ogsws338dbive3ft03rmu1ynfouspf/InstallAssistant.pkg";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallAssistantSonoma.pkg";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
            else
            {
                Console.WriteLine("Download incomplete.");
            }
        }

        public static void ventura()
        {
            string url = "https://swcdn.apple.com/content/downloads/62/04/082-42293-A_BLBGWQXWM6/yxa6zwy8dit7wkvu39onjf7u60t235z0k0/InstallAssistant.pkg";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallAssistantVentura.pkg";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
            else
            {
                Console.WriteLine("Download incomplete.");
            }
        }

        public static void monterey()
        {
            string url = "https://swcdn.apple.com/content/downloads/46/57/052-60131-A_KM2RH04C2D/9yzvba1uvpem2wuo95r459qno57qaizwf2/InstallAssistant.pkg";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallAssistantMonterey.pkg";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
            else
            {
                Console.WriteLine("Download incomplete.");
            }
        }

        public static void bigSur()
        {
            string url = "http://swcdn.apple.com/content/downloads/14/38/042-45246-A_NLFOFLCJFZ/jk992zbv98sdzz3rgc7mrccjl3l22ruk1c/InstallAssistant.pkg";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallAssistantBigSur.pkg";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
            else
            {
                Console.WriteLine("Download incomplete.");
            }
        }

        public static void catalina()
        {
            string url = "https://apps.apple.com/us/app/macos-catalina/id1466841314";
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        public static void mojave()
        {
            string url = "https://apps.apple.com/us/app/macos-mojave/id1398502828";
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        public static void highSierra()
        {
            string url = "https://apps.apple.com/us/app/macos-high-sierra/id1246284741";
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        public static void sierra()
        {
            string url = "http://updates-http.cdn-apple.com/2019/cert/061-39476-20191023-48f365f4-0015-4c41-9f44-39d3d2aca067/InstallOS.dmg";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallOSSierra.dmg";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }



        }
        public static void elCapitan()
        {
            string url = "http://updates-http.cdn-apple.com/2019/cert/061-41424-20191024-218af9ec-cf50-4516-9011-228c78eda3d2/InstallMacOSX.dmg";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallMacOSXElCapitan.dmg";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void yosemite()
        {
            string url = "http://updates-http.cdn-apple.com/2019/cert/061-41343-20191023-02465f92-3ab5-4c92-bfe2-b725447a070d/InstallMacOSX.dmg";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallMacOSXYosemite.dmg";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }


        }

        public static void mavericks()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not Avail");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void mountainLion()
        {
            string url = "https://updates.cdn-apple.com/2021/macos/031-0627-20210614-90D11F33-1A65-42DD-BBEA-E1D9F43A6B3F/InstallMacOSX.dmg";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallMacOSXMountainLion.dmg";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void lion()
        {
            string url = "https://updates.cdn-apple.com/2021/macos/041-7683-20210614-E610947E-C7CE-46EB-8860-D26D71F0D3EA/InstallMacOSX.dmg";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallMacOSXLion.dmg";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void snowLeopard()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not Avail");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void leopard()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not Avail");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void tiger()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not Avail");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void panther()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.1.iso";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallMacOSXPantherDisk1.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        downloader.pantherTwo();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }


        }

        public static void pantherTwo()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.2.iso";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallMacOSXPantherDisk2.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        downloader.pantherThree();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void pantherThree()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/10.3/Apple.Mac.OS.X.10.3.0.-.Disk.3.iso";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallMacOSXPantherDisk3.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }

        }

        public static void jaguar()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/10.2/disk1.iso";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallMacOSXJaguarDisk1.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        downloader.jaguarTwo();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void jaguarTwo()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/10.2/disk2.iso";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallMacOSXJaguarDisk2.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        main.mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void puma()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/10.1/osx_101_5g64_install.iso";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallMacOSXPuma.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        main.mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void cheetah()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/osx10.0/osx-10.0.iso";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "InstallMacOSXCheetah.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        main.mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void mac9()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/9.2/macos_921_ppc.iso";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "macos92.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        main.mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void mac8()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/8.6/MacOS86.iso";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "macos86.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        main.mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void mac7()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/7/System.7.1.CD.iso";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "system71.iso";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        main.mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void mac6()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/6/System.Tools.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System6.System.Tools.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        downloader.mac62();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void mac62()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/6/Printing.Tools.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System6.Printing.Tools.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        downloader.mac63();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void mac63()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/6/Utilities.1.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System6.Utilities.1.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        downloader.mac64();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }

            
        }

        public static void mac64()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/6/Utilities.2.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System6.Utilities.2.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        main.mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }

            }
        }

        public static void mac5()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/5.0/System.Tools.1.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System5.System.Tools.1.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        downloader.mac51();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
            }

        public static void mac51()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/5.0/System.Tools.2.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System5.System.Tools.2.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        downloader.mac52();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
        }

        public static void mac52()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/5.0/Utilities.1.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System5.Utilities.1.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        downloader.mac53();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
        }

        public static void mac53()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/5.0/Utilities.2.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System5.Utilities.2.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        main.mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
        }

        public static void mac4()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/4/System.Tools.2.0.1.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System4.System.Tools.2.0.1.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        downloader.mac41();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
        }

        public static void mac41()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/4/Utilities.2.1.Disk.1.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System4.Utilities.2.1.Disk.1.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        downloader.mac42();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
        }

        public static void mac42()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/4/Utilities.2.1.Disk.2.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System4.Utilities.2.1.Disk.2.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        main.mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
        }

        public static void mac3()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/3/System.Tools.512ke.v1.0.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System3.System.Tools.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        downloader.mac31();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
        }

        public static void mac31()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/3/Utilities.1.0.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System3.Utilities.1.0.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        main.mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
        }

        public static void mac2()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/sys2/System.Disk.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System2.System.Disk.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        main.mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
        }

        public static void mac1()
        {
            string url = "https://github.com/miniusbhater/diskimages/releases/download/sys1/System.Disk.img";
            Console.WriteLine($"Downloading from: {url}");
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string directoryPath = Path.Combine(docs, "GetThatOS");

            Console.WriteLine("By default the installer will be downloaded to documents\\GetThatOS\nIs this okay? (y/n)");
            var keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.Key != ConsoleKey.Y)
            {
                Console.WriteLine("\nFile path:");
                string newPath = Console.ReadLine();
                directoryPath = newPath;

            }

            string fileName = "System1.System.Disk.img";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Would you like to start the download? (y/n)");
            var keyInfo1 = Console.ReadKey(intercept: true);
            if (keyInfo1.Key == ConsoleKey.Y)
            {
                using (WebClient webclient = new WebClient())
                using (ManualResetEvent downloadFinished = new ManualResetEvent(false))
                {
                    webclient.DownloadProgressChanged += (s, ev) =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Downloading... {ev.ProgressPercentage}%");
                    };

                    webclient.DownloadFileCompleted += (s, ev) =>
                    {
                        Console.WriteLine($"Download complete!\nInstaller located at {fullPath}");
                        downloadFinished.Set();
                        Thread.Sleep(5000);
                        main.mainMenu.menu();
                    };

                    webclient.DownloadFileAsync(new Uri(url), fullPath);

                    downloadFinished.WaitOne();
                }
            }
        }

        //-------------------------------------------------------------Win----------------------------------------------------------------------------------


    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GetThatOSCLI.update
{
    internal class updater
    {
        public static void clearConsole()
        {
            Console.Clear();
            updateGOS();
        }

        public static async void updateGOS()
        {
            Version currentVer = Assembly.GetExecutingAssembly().GetName().Version;
            Version currentVersion = currentVer;
            using HttpClient httpclient = new HttpClient();
            string gist = $"https://gist.githubusercontent.com/miniusbhater/6df05eab2c8e3e8b0d695d6b3d4a1437/raw/gistfile1.txt?nocache={Guid.NewGuid()}";
            string versionContent = await httpclient.GetStringAsync(gist);
            if (Version.TryParse(versionContent.Trim(), out Version latestVersion))
            {
                Console.WriteLine($"Current Version: {currentVersion}");
                Console.WriteLine($"Updating to: {latestVersion}");
            }
            Console.WriteLine("Beginning update");
        }
    }
}

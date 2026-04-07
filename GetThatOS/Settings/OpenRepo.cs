using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetThatOS.Settings
{
    internal class OpenRepo
    {
        public static void Repo()
        {

            var psi = new ProcessStartInfo
            {
                FileName = @"C:\Program Files (x86)\GetThatOS\GetThatOS Repository.url",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}

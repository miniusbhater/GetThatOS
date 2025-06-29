using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetThatOSCLI.main
{
    internal class mainMenu
    {
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to GetThatOS!");
            Console.WriteLine("\n\n1. Windows\n2. macOS\n3. Linux\n4. Other");
            while (true)
            {
                var keyInfo = Console.ReadKey(intercept: true);

                if (keyInfo.Key == ConsoleKey.D2)
                {
                    main.macMenu.menu();
                }
            }
        }
    }
}

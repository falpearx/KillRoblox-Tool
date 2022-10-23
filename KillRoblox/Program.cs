using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KillRoblox
{
    internal class Program
    {
        public static void Print(string text, int speed)
        {
            foreach (char value in text)
            {
                Console.Write(value);
                Thread.Sleep(speed);
            }
            Console.WriteLine();
        }

        public static void change(string text)
        {
            Console.Title = text;
        }

        public static void killroblox()
        {
            Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
            int num = 0;
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
                num++;
            }
            Program.Print(string.Format("Terminated {0} Process", num), 25);
        }

        static void Main(string[] args)
        {
            Program.change("Kill Roblox Tool");
            Program.killroblox();
            //Program.Print("We are done! Closing this in 3 seconds...", 25);
            //Thread.Sleep(3000);
            Program.Print("Press any key to exit...", 25);
            Console.ReadKey();
        }


    }
}

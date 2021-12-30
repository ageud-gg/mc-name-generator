using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NameGen
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string title = @" /$$      /$$  /$$$$$$  /$$   /$$        /$$$$$$                     
| $$$    /$$$ /$$__  $$| $$$ | $$       /$$__  $$                    
| $$$$  /$$$$| $$  \__/| $$$$| $$      | $$  \__/  /$$$$$$  /$$$$$$$ 
| $$ $$/$$ $$| $$      | $$ $$ $$      | $$ /$$$$ /$$__  $$| $$__  $$
| $$  $$$| $$| $$      | $$  $$$$      | $$|_  $$| $$$$$$$$| $$  \ $$
| $$\  $ | $$| $$    $$| $$\  $$$      | $$  \ $$| $$_____/| $$  | $$
| $$ \/  | $$|  $$$$$$/| $$ \  $$      |  $$$$$$/|  $$$$$$$| $$  | $$
|__/     |__/ \______/ |__/  \__/       \______/  \_______/|__/  |__/
                                                                     
                                                                     
                                                                     ";
            Start:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Loading...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(title);
            Console.WriteLine("\n\n===================\n");
            Console.WriteLine("Generate a 4 letter name - 1");
            Console.WriteLine("Generate a 5 letter name - 2");
            Console.WriteLine("Quit - 3");
            Console.WriteLine("\n\n===================\n");
            if (Console.ReadLine() == "1")
            {
                Console.Clear();
                Console.WriteLine(title);
                var accounts4 = new WebClient().DownloadString("https://pastebin.com/raw/sfVwq4pZ").Split('\n');
                string account44 = accounts4[new Random().Next(0, accounts4.Length)];
                Console.WriteLine(account44);
                Console.WriteLine("\n\n===================\n");
                Console.WriteLine("Open namemc - 1");
                Console.WriteLine("Return to start - 2");
                Console.WriteLine("Quit - 3");
                if (Console.ReadLine() == "1")
                {
                    System.Diagnostics.Process.Start("https://namemc.com/profile/" + account44);
                }

                if (Console.ReadLine() == "2")
                {
                    goto Start;
                }


                if (Console.ReadLine() == "3")
                {
                    Console.Clear();
                    System.Threading.Thread.Sleep(1000);
                    Environment.Exit(0);
                }

            }
            else
            {
                Console.WriteLine("Unknown command, Please try again!");
            }

            if (Console.ReadLine() == "2")
            {
                Console.Clear();
                Console.WriteLine(title);
                var accounts5 = new WebClient().DownloadString("https://pastebin.com/raw/0nLYXyJ6").Split('\n');
                string accounts55 = accounts5[new Random().Next(0, accounts5.Length)];
                Console.WriteLine(accounts55);
                Console.WriteLine("\n\n===================\n");
                Console.WriteLine("Open namemc - 1");
                Console.WriteLine("Return to start - 2");
                Console.WriteLine("Quit - 3");

                if (Console.ReadLine() == "1")
                {
                    System.Diagnostics.Process.Start("https://namemc.com/profile/" + accounts55);
                }
              

                if (Console.ReadLine() == "2")
                {
                    goto Start;
                }
               
                if (Console.ReadLine() == "3")
                {
                    Console.Clear();
                    System.Threading.Thread.Sleep(1000);
                    Environment.Exit(0);
                }

            }
            else
            {
                Console.WriteLine("Unknown command, Please try again!");
            }

            if (Console.ReadLine() == "3")
            {
                Console.Clear();
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("Unknown command, Please try again!");
            }

        }
    }
}

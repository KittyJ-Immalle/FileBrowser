using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Geef een argument mee.");
            } else
            {
                string c = Directory.GetCurrentDirectory();

                switch (args[0])
                {
                    case "-c":
                        Console.WriteLine("Current directory:");

                        Console.WriteLine(c);
                        break;
                    case "-d":
                        Console.WriteLine("All subdirectories in current directory:");
                        

                        break;
                    case "-f":
                        Console.WriteLine("All files in current directory:");
                        break;
                    case "-h":
                        Console.WriteLine("----help----");
                        Console.WriteLine("-c | Shows current directory");
                        Console.WriteLine("-d | Shows all subdirectories in current directory");
                        Console.WriteLine("-f | Shows all files in current directory");
                        Console.WriteLine("-h | Shows help");
                        break;
                    default:
                        Console.WriteLine("Onbekend argument");
                        break;
                }

            }

        }

        
    }
}

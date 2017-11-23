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
            String[] subdirectories;

            if(args.Length == 0)
            {
                Console.WriteLine("Please execute with an argument.");
            } else
            {

                switch (args[0])
                {
                    case "-c":
                        Console.WriteLine("Current directory:");
                        Console.WriteLine(Directory.GetCurrentDirectory());
                        break;
                    case "-d":
                        Console.WriteLine("All subdirectories in current directory:");
                        subdirectories = Directory.GetDirectories(Directory.GetCurrentDirectory());
                        foreach (String dir in subdirectories) {
                            Console.WriteLine(dir);
                        }
                        break;
                    case "-f":
                        Console.WriteLine("All files in current directory:");
                        string[] files = Directory.GetFiles(Environment.CurrentDirectory);
                        foreach (string file in files)
                        {
                            Console.WriteLine(Path.GetFileName(file));
                        }
                        break;
                    case "-h":
                        Console.WriteLine("----help----");
                        Console.WriteLine("-c | Shows current directory");
                        Console.WriteLine("-d | Shows all subdirectories in current directory");
                        Console.WriteLine("-f | Shows all files in current directory");
                        Console.WriteLine("-h | Shows help");
                        break;
                    default:
                        Console.WriteLine("Unknown argument, give argument -h for help.");
                        break;
                }

            }

        }

        
    }
}

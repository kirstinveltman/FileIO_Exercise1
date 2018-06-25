using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number: ");
            string userText = Console.ReadLine();
            File.WriteAllText(@"C:\Users\derwy\source\repos\Text_Files\FileIO_Logs\log.txt", userText);

            string repeatText = File.ReadAllText(@"C:\Users\derwy\source\repos\Text_Files\FileIO_Logs\log.txt");
            Console.WriteLine("Here is your number: {0}", repeatText);
            Console.ReadLine();

        }
    }
}

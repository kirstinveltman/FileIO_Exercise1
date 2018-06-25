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
            // page 104 exercises for logging
            Console.WriteLine("Please enter a number: ");
            string userText = Console.ReadLine();
            File.WriteAllText(@"C:\Users\derwy\source\repos\Text_Files\FileIO_Logs\log.txt", userText);

            string repeatText = File.ReadAllText(@"C:\Users\derwy\source\repos\Text_Files\FileIO_Logs\log.txt");
            Console.WriteLine("Here is your number: {0}", repeatText);
            Console.ReadLine();


            // page 106 exercises for DateTime
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("The current date and time is: {0}", currentDateTime);

            Console.WriteLine("\nPlease enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            DateTime newDateTime = currentDateTime.AddHours(userNumber);

            Console.WriteLine("Your number ({0}) of hours from now is {1}.", userNumber, newDateTime);
            Console.ReadLine();

        }
    }
}

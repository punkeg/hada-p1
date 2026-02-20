using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the HadaP1 Converter!");
            Console.WriteLine("1. Convert Seconds to Minutes");
            Console.WriteLine("2. Convert Hours to Minutes");
            Console.Write("Please select an option (1 or 2): ");
            
            string response = Console.ReadLine();
            
            Console.Write("Enter the amount to convert: ");
            double amount = double.Parse(Console.ReadLine());

            if (response == "1")
            {
                double minutes = HadaP1.Seconds2Minutes(amount);
                Console.WriteLine($"{amount} seconds is equal to {minutes} minutes.");
            }
            else if (response == "2")
            {
                double minutes = HadaP1.Hours2Minutes(amount);
                Console.WriteLine($"{amount} hours is equal to {minutes} minutes.");
            }
            else
            {
                Console.WriteLine("Invalid option selected.");
            }
            
            // Keep the console open until the user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}


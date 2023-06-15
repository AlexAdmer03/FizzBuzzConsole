using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsole
{
    public class Application
    {
        private Logic logic = new Logic();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1. Run FizzBuzz for numbers 1-100");
                Console.WriteLine("2. Run FizzBuzz for a chosen number");
                Console.WriteLine("3. Exit");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        for (int i = 1; i <= 100; i++)
                        {
                            Console.WriteLine(logic.FizzBuzz(i));
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter a number:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(logic.FizzBuzz(num));
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please choose 1, 2 or 3.");
                        break;
                }
            }
        }
    }
}

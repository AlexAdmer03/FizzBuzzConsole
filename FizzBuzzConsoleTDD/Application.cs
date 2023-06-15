using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsoleTDD
{
    public class Application
    {
        public void Run(string[] args)
        {
            Logic logic = new Logic();
            Console.WriteLine("Välkommen till FizzBuzz! Välj ett alternativ:");
            Console.WriteLine("1. Kör FizzBuzz för siffror mellan 1-100");
            Console.WriteLine("2. Välj en siffra att köra FizzBuzz på");

            var val = Console.ReadLine();
            switch (val)
            {
                case "1":
                    for (int i = 1; i <= 100; i++)
                    {
                        Console.WriteLine($"{i}: {logic.FizzBuzz(i)}");
                    }
                    break;
                case "2":
                    Console.WriteLine("Ange en siffra:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(logic.FizzBuzz(number));
                    break;
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }
        }
    }
}

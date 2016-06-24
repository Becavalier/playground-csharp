using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type something and press the Enter key.");

            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed:" + userValue);
            //Console.ReadLine();

            Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3 ?");
            string userValue = Console.ReadLine();
            try
            {
                if (int.Parse(userValue) == 1)
                {
                    Console.WriteLine("You won a new car!");
                    Console.ReadLine();
                }
                else if (int.Parse(userValue) == 2)
                {
                    Console.WriteLine("You won a new boat!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You lose the game!");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.GetBaseException());
                Console.WriteLine("Please input a real number!");
                Console.ReadLine();
            }

            Console.WriteLine("Please input a string:");

            string inputStr = Console.ReadLine();
            string message = (inputStr == "Bob") ? "You win the game!" : "You lose the game!";

            Console.WriteLine("The message is {0}", message);
            Console.ReadLine();


        }
    }
}

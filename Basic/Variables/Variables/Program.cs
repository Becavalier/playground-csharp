using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 7;
            */

            // Strong declaration
            string myFirstName = "Jason";

            // Weak declaration, must be set a value!
            var myLastName = "Yu";

            Console.WriteLine(myFirstName);
            Console.ReadLine();



            int x = 10;
            string myFirstTry = "Bob";
            string mySecondTry = "10";

            Console.WriteLine(x.ToString() + myFirstTry);
            Console.WriteLine(x + int.Parse(mySecondTry));
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_RangeLimitations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jack Anthony D. Yagonia
            //IT306
            //Check if a number entered by the user is between a certain range of numbers (inclusive).

            int firstNum = 30;
            int secondNum = 50;

        Main:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This system tells whether the number that the user has given is either withing  '\nthe range limit or beyond the range limit of 30 to 50.");
            Console.Write("'\nProvide a certain number: ");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number >= 30 && number <= 50)
            {
                Console.WriteLine("The number provided is inside the range limit.");
            }

            else
            {
                Console.WriteLine("The number provided is outside the range limit.");
            }

            Console.Write("\nDo you want to have another entry(y/n)?: ");
            char ans = Convert.ToChar(Console.ReadLine());

            if (ans == 'y')
            {
                goto Main;
            }
            else if (ans == 'n')
            {
                return;
            }


            Console.ReadKey();
        }
    }
}

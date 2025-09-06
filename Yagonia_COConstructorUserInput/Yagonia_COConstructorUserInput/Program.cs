using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_COConstructorUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Jack Anthony D. Yagonia
        //IT306
        //EXER_03: User Input with Constructor

        Main:

            Console.Clear();
            //Will ask the user to input values
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This program will ask you about your favorite phone:\n");
            Console.Write("Enter phone brand:\t");
            string aBrand = Console.ReadLine();
            Console.Write("Enter phone model:\t");
            string aModel = Console.ReadLine();
            Console.Write("Enter phone storage:\t");
            int aStorage = int.Parse(Console.ReadLine());

            //Instantiation of a new object
            Phone phone1 = new Phone(aBrand, aModel, aStorage);

            //Call the method to display
            phone1.DisplayPhoneDetails();

            //Input another phone details
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_Badminton_Constructors_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Jack Anthony D. Yagonia
            //Section: IT306
            //Yagonia_EXER2: MyClassAndObjects

            Players player1 = new Players();
            Players player2 = new Players();

            //Initialization of fields
            player1.name = "Lin Dan";
            player1.from = "China";
            player1.titles = "\n2 Olympic gold medals (2008, 2012)\n5 World Championship titles\n6 All England Open titles";

            player2.name = "Lee Zi Jia";
            player2.from = "Malaysia";
            player2.titles = "\nSecured the gold medal in the Asian Championships in 2022.\nBWF World Tour Titles: Won the Thailand Open and the Hylo Open.\nParis Olympics: Won a bronze medal in the men's singles event at the 2024 Paris Olympics.";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Here are my favorite badminton players: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPlayer Name :" + player1.name + "\nCountry From : " + player1.from + "\nTitles : " + player1.titles);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPlayer Name :" + player2.name + "\nCountry From : " + player2.from + "\nTitles : " + player2.titles);

            Console.ReadLine();
        }
    }
}

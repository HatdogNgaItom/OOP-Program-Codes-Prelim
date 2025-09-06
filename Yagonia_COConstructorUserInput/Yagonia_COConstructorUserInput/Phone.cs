using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yagonia_COConstructorUserInput
{
    internal class Phone
    {
        //Declaring fields
        public string brand;
        public string model;
        public int storage;

        public Phone(string aBrand, string amodel, int aStorage)    //Parameterized Constructors
        {
            brand = aBrand;
            model = amodel;
            storage = aStorage;
        }

        //Method to display the book details
        public void DisplayPhoneDetails()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("============= Here are the Phone details of your enlisted favorite phones =============\n");
            Console.WriteLine("Phone Brand: \t" + brand);
            Console.WriteLine("Phone Models: \t" + model);
            Console.WriteLine("Phone Storage: \t" + storage);
        }
    }
}

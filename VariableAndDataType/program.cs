using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartTestApp
//namespace is block of class definition
{
    class Program
    //A class is block of method
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My First C# Program!");
            //  Console.WriteLine() method will print out the string
            //  Console is in-built class
            //  Writeline is method in Console class

            double mobilePrice = 10000.00;
            short quantity = 1;
            double discount = 0.04;
            double totalPrice = mobilePrice - mobilePrice * discount;
            double discountedPrice = mobilePrice * discount;
            Console.WriteLine("Total Price = {0}\nDiscounted Price = {1}", totalPrice, discountedPrice);
            Console.WriteLine("Quantity {0}", quantity);
        }
    }
}

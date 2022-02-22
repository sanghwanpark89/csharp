using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;

namespace QuickKartTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customerOne = new Customer();
            Console.WriteLine("Customer Id: " + customerOne.CustomerID);
            Console.WriteLine();

            Customer customerTwo = new Customer();
            Console.WriteLine("Customer Id: " + customerTwo.CustomerID);
            Console.WriteLine();

            //used to create an object with three inputs
            Customer customerThree = new Customer(1002, "Kate", "kate@gmail.com");
            Console.WriteLine("Customer Id: " + customerThree.CustomerID);
            Console.WriteLine("Customer Name: " + customerThree.CustomerName);
            Console.WriteLine("Customer EmailId: " + customerThree.EmailId);
            Console.WriteLine();

            //used to create an object with four inputs
            Customer customerFour = new Customer(1002, "Kate", "kate@gmail.com");
            Console.WriteLine("Customer Id: " + customerThree.CustomerID);
            Console.WriteLine("Customer Name: " + customerThree.CustomerName);
            Console.WriteLine("Customer EmailId: " + customerThree.EmailId);
            Console.WriteLine();

        }
    }
}

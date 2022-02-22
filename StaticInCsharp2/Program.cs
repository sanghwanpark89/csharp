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
            Customer customerTwo = new Customer(); 
            Customer customerThree = new Customer();

            Console.WriteLine("Customer ID = " +customerOne.CustomerId);
            Console.WriteLine("Customer ID = " +customerTwo.CustomerId);
            Console.WriteLine("Customer ID = " + customerThree.CustomerId);

            Console.WriteLine("Total number of customers registeres = " + Customer.GetNumberOfCustomers());
            /*
             * Static methods are conceptually same as static variables, they belong to a class and not an individual object.
             * We need to print the total number of customers registered without using any object reference.
             */ 

        }
    }
}

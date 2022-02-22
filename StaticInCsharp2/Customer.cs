using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        private static int counter;

        /*
         * By making the variable as static, it becomes part of the class and not an individual object
         * Note:
         * Static variable belongs to the class and not go an object instance
         * The static variables are initialized only once, at the start of the execution
         * A single copy to be shared by all instance of the class
         * A static variable can be accessed directly by the class name and does not need any object
         */


        static Customer()
        {
            counter = 1000;
        }

        public Customer()
        {
            //counter = 1000;
            CustomerId = ++counter;
            Console.WriteLine(counter);
        }

        public static int GetNumberOfCustomers()
        {
            counter -= 1000;
            return counter;
        }

        /*
         * static methods can not be invoked using object reference
         * It is a method which belongs to the class and not to the object
         * A static method can access only static data. It can not access non-static data(instance variables)
         * A static method can be accessed directlty by the class name and does not need any object
         */
    }
}

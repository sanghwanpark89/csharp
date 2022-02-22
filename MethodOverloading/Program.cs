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
            Product productObj = new Product("P116", "Samsung Galaxy S4", 10, 38000.00);

            Console.WriteLine("Product Price = " + productObj.Price);

            Console.WriteLine("Quantity Available = " + productObj.QuantityAvailable);

            productObj.UpdateProductDetails(36000.00);

            Console.WriteLine("Product Price = " + productObj.Price);
            Console.WriteLine();

            productObj.UpdateProductDetails(8);

            Console.WriteLine("Quantity Available = " + productObj.QuantityAvailable);
            Console.WriteLine();

            productObj.UpdateProductDetails(35000.00, 7);

            Console.WriteLine("Product Price = " + productObj.Price); ;
            Console.WriteLine("Quantity Avaiolable = " + productObj.QuantityAvailable);

            /*
             * the process of implementing same method name but with different input parameters, datatype or the order of parameters is called as Method Overloading
             */

        }
    }
}

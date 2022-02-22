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
            Console.WriteLine("---- Enter the product details ---");
            Console.WriteLine("ProductName = ");
            string productName = Console.ReadLine();

            Console.WriteLine("Price = ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("QuantityAvailable = ");
            int quantityAvailable = Convert.ToInt32(Console.ReadLine());

            try
            {
                Product product = new Product("P101", productName, price, quantityAvailable);
                if(product != null)
                {
                    Console.WriteLine("\nProduct details stored successfully\n");
                }
            }
            catch (InvalidPriceException ie)
            {
                Console.WriteLine(ie.Message);
            }
        }
    }
}

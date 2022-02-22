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
            Product[] productArray = new Product[4];

            try
            {
                Product productOne = new Product("P101", "Sports shoe", 1599.00, 25);
                Product productTwo = new Product("P102", "Denim shirt", 1500.99, 50);
                Product productThree = new Product("P103", "Laptop bag", 1400.93, 10);
                Product productFour = new Product("P104", "Mobile cover", 895.00, 10);

                productArray[0] = productOne;
                productArray[1] = productTwo;
                productArray[2] = productThree;
                productArray[3] = productFour;

                Console.WriteLine("ProductID\tProductName\tPrice\t\tQuantityAvailable");
                Console.WriteLine("-----------------------------------------------------------------");

                for (int i = 0; i < productArray.Length; i++)
                {
                    Console.WriteLine("{0, -10}\t{1}\t{2}\t\t{3}",
                        productArray[i].ProductId,
                        productArray[i].ProductName,
                        productArray[i].Price,
                        productArray[i].QuantityAvailable
                        );
                }
            }
            
            catch(NullReferenceException ne)
            {
                Console.WriteLine("\nNo further details available...");
                Console.WriteLine("\nError message: " + ne.Message);
                Console.WriteLine("Stack trace: " + ne.StackTrace);
            }

            catch(IndexOutOfRangeException ie)
            {
                Console.WriteLine("\nNo space to store the product details...");
                Console.WriteLine("\nError message: " + ie.Message);
                Console.WriteLine("Stack trace: " + ie.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nNo space to store the product details...");
            }
            finally
            {
                Console.WriteLine("\nFinally Block will be executed no matter what happened = " + productArray.Length);
            }

            Console.WriteLine("\nFinally Block will be executed no matter what happened = " + productArray.Length);


            //Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}

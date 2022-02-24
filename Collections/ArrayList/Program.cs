using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;
using System.Collections;

namespace QuickKartTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            //Create the cart Object
            //cart variable will have the address of cart Object

            Product productOne = new Product("Tennis Racket", 1099.99, 50, 1);
            Product productTwo = new Product("Tennis Ball", 300.00, 100, 1);
            Product productThree = new Product("Dining Table", 15000, 10, 2);




            //Initiate the product values which have product name, price, available quantity and product number

            string cartDetails = cart.getCartDetails();
            Console.WriteLine(cartDetails);
            Console.WriteLine();

            cart.AddToCart(productOne);
            cart.AddToCart(productTwo);
            cart.AddToCart(productThree);

            cartDetails = cart.getCartDetails();
            Console.WriteLine(cartDetails);
            Console.WriteLine();

            ArrayList productsInCart = cart.GetCartProductDetails();

            cart.RemoveFromCart(productTwo);

            Product productFour = new Product("Laptop Table", 7000.00, 15, 2);
            Product productFive = new Product("Corduroy Shirt", 2000, 100, 3);

            cart.AddToCart(productFour);
            cart.AddToCart(productFive);

            cartDetails = cart.getCartDetails();
            Console.WriteLine(cartDetails);
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("{0, -13}{1, -20}{2, -10}{3, -20}\t{4}", "ProductId", "ProductName", "Price", "QuantityAvailable", "CategoryId");
            Console.WriteLine("--------------------------------------------------------------------------");

            foreach(Product product in productsInCart)
            {
                Console.WriteLine("{0, -13}{1, -20}{2, -10}{3, -20}\t{4}",
                                    product.ProductId,
                                    product.ProductName,
                                    product.Price,
                                    product.QuantityAvailable,
                                    product.CategoryId);

            }
            Console.WriteLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        
        private double price;
        public int QuantityAvailable { get; set;}

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value <= 0)
                {
                    InvalidPriceException exObj = new InvalidPriceException("\nPrice cannot be less than or equal to zero. " + "\nProduct details cannot be stored.\n");
                    
                    //if the price is less than or equal to zero, the exception will be occurred and
                    
                    throw exObj;
                    //Exception will be throwed
                }
                else
                {
                    this.price = value;
                }
            }
        }


        public Product(string productId, string productName, double price, int quantityAvailable)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            QuantityAvailable = quantityAvailable;

        }
    }


}

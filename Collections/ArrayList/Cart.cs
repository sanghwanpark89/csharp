using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QuickKartBL
{
    public class Cart
    {
        public ArrayList Products { get; set; }

        //public int Size { get; set; }

        //public int IndexNumber { get; set; }

        public Cart()
        {
            this.Products = new ArrayList();
            //this.Size = size;
            //this.IndexNumber = 0;
        }

        public void AddToCart(Product product)
        {
            this.Products.Add(product);
        }

        public void RemoveFromCart(Product productToRemove)
        {
            this.Products.Remove(productToRemove);
        }

        public ArrayList GetCartProductDetails()
        {
            return this.Products;
        }

        public string getCartDetails()
        {
            int capacity = this.Products.Capacity;
            int count = this.Products.Count;

            string details = string.Empty;

            details += "Cart Capacity = " + capacity;
            details += "\nProducts Count = " + count;
            return details;
        }


    }
}

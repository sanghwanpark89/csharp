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
            string productName = "Samsung Galaxy J7";
            double mobilePrice = 15000.00;
            short quantity = 100;
            object obj = quantity;
            short quantityOne = (short)obj;
            double discount = .05;
            //array of objects
            object[] productDetails = { productName, mobilePrice, quantity, discount };
            /*
             * all the variables are added to an array of product details.
             * which is an object array named productDetails.
             * This is possible because object is the parent type of all datatypes in CSharp.
             * That means it is capable of holding values of any datatype.
             * 
             * When you  assign short, double or int datatype to object, 
             * they will be converted into reference type object. 
             * The process of converting value type to reference type is called as Boxing. 
             * When a value of any type is pointed by a reference of an object, it gets copied onto heap.
             */

            /*
             * Consider the same variable obj of type object where the reference obj is stored in stack memory and the value is stored in heap.
             * when you perform unboxing ie (short)obj and assign it to a new variable quantityOne. 
             * This creates another valuetype called  quantityOne on the stack and copies the value 100 from heap back to stack.
             */
            Purchase purchase1 = new Purchase();
            purchase1.PrintPurchaseDetails(productDetails);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;

namespace QuickKartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer = new Customer("John", "999999999", CustomerCardType.Gold);
            Console.WriteLine("Card Type selected: " + customer.cardtype);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Purchase
    {
        public void PrintPurchaseDetails(object[] purchaseDetails)
        {
            Console.WriteLine("Purchase Details are :");
            Console.WriteLine("----------------------------------------------");
            foreach (object item in purchaseDetails)
                Console.WriteLine(item);
            Console.WriteLine("----------------------------------------------");

        }
    }
}

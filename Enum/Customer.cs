using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {

        public string name;
        public string contactNumber;
        public CustomerCardType cardtype;

        public Customer(string name, string contactNumber, CustomerCardType cardtype)
        {
            this.name = name;
            this.contactNumber = contactNumber;
            this.cardtype = cardtype;
        }

    }
}

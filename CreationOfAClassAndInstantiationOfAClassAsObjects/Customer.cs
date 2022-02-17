using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        public int customerId;
        public string customerName;
        public string address;
        public long phoneNumber;
        public string emailId;
        public string DisplayCustomerDetails()
        {
            string details = "Customer ID = " + customerId;
            details += "\nCustomer Name = " + customerName;
            details += "\nAddress = " + address;
            details += "\nPhone Number = " + phoneNumber;
            details += "\nEmail ID = " + emailId;

            return details;
        }

        //the method DisplayCustomerDetails will return string value which isi about the customer
    }
}

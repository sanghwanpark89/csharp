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

        public Customer(int customerId, string customerName, string address, long phoneNumber, string emailId)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.emailId = emailId;
        }

        /*
         * A constructor is a special method with the same name as the class.
         * It is access specifier is ususally public and doe not return any value.
         * You should not even use a void, even if the constructor does not return a value.
         * You can assign initial values to the instance variable of the class, inside this constructor.
         */
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

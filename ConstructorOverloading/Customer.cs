using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string customerContact { get; set;}

        public string EmailId { get; set; }

        public string Address { get; set; }

        public Customer()
        {
            CustomerID = 1001;
        }

        //To create a customer object with customer id, name and email id.
        public Customer(int customerId, string customerName, string emailId)
        {
            this.CustomerID = customerId;
            this.CustomerName = customerName;
            this.EmailId = emailId;
        }

        //To create a customer Object with name, contact number, email id and address

        public Customer(string customerName, string customerContact, string emailId, string address)
        {
            this.CustomerName = customerName;
            this.customerContact = customerContact;
            this.EmailId = emailId;
            this.Address = address;
        }

        /*
         * Parameterized constructors not only allow us to supply different values to different objects, 
         * they also allow us to customize object creation based on available input, for exampel to create a customer object only with 
         * CustomerId, CustomerName, and EmailID we4 can use the first parameterized constructor in the above code snippet, and to create a customer object with 
         * CustomerNa,e CustomerContact, EmailId and Address we can use the second parameterized constructor as shown in the above code snippet.
         * 
         * As you know the name of the constructor should be same sa the class name, the only way to define multiple constructor is by overloading them like method overloading
         */
    }
}

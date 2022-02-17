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
            Customer customerOne = new Customer(1001,"Alfred","12th Block, Gandhi Square", 9876545678,"alfred@gmail.com");
            //Create customerOne Instance
            customerOne.customerId = 1001;
            customerOne.customerName = "Alfred";
            customerOne.address = "12th Block, Gandhi Square";
            customerOne.phoneNumber = 9876545678;
            customerOne.emailId = "alfred@gmail.com";

            /*
             * Customer will have 
             * 1001 as customerId
             * Alfred as customerName
             * 12th Block, Gandhi Square as address
             * 987654678 as phoneNumber
             * alfred@gmail as email Id
             */

            string customerOneDetails = customerOne.DisplayCustomerDetails();
            //customerOneDetails which is string variable will have the value which is returned from displaycustomerdetails method
            Console.WriteLine(customerOneDetails);
            //Print

            Console.WriteLine("----------------------------");

            Customer customerTwo = new Customer(1002,"Juliet","14th Block, Nehru Square", 9855645612, "juliet@gmail.com");
            //customerTwo.customerId = 1002;
            //customerTwo.customerName = "Juliet";
            //customerTwo.address = "14th Block, Nehru Square";
            //customerTwo.phoneNumber = 9855645612;
            //customerTwo.emailId = "juliet@gmail.com";

            /*
             * Customer will have 
             * 1002 as customerId
             * Juliet as customerName
             * 14th Block, Nehru Square as address
             * 9855645612 as phoneNumber
             * juliet@gmail.com as email Id
             */

            string customerTwoDetails = customerTwo.DisplayCustomerDetails();
            //customerTwoDetails which is string variable will have the value which is returned from displaycustomerdetails method
            Console.WriteLine(customerTwoDetails);

            CustomerDateOfBirth cust;
            cust.custDoBDate = 06;
            cust.custDoBMonth = 06;
            cust.custDoBYear = 1995;
            Console.WriteLine(cust.custDoBDate);
            Console.WriteLine(cust.custDoBMonth);
            Console.WriteLine(cust.custDoBYear);
            
            //the variable cust which is of struct type directly store the data of the struct, not the address of the memory location
        }
    }
}

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
            ContactDetails<long> mobileContacts = new ContactDetails<long>(3);
            
            /*
             * When you create an object of the generic class, the type'long' will be passed as parameter to the class and every T will be replaced with the data 'long' in the generic class.
             */
            
            mobileContacts.AddContact(12345678911);
            mobileContacts.AddContact(12312312322);
            mobileContacts.AddContact(12345612333);

            ContactDetails<string> emailContacts = new ContactDetails<string>(3);
            emailContacts.AddContact("abc@gmail.com");
            emailContacts.AddContact("bcd@gmail.com");
            emailContacts.AddContact("erf@gmail.com");

            Random randomNumber = new Random();
            int luckyNumber = randomNumber.Next(0, 3);
            //you should implement code to randomly pick contact details.
            //Use the random number generator and generate a random number between 0 and 3.


            long mobileNumber = (long) mobileContacts.GetContactDetails(luckyNumber);
            string emailId = (string) emailContacts.GetContactDetails(luckyNumber);

            Console.WriteLine("Selected mobile number: " + mobileNumber);
            Console.WriteLine("Selected email Id: " + emailId);

            ContactDetails<object> contacts = new ContactDetails<object>(6);
            contacts.AddContact(9845020724);
            contacts.AddContact("AAA@gmail.com");
            contacts.AddContact(7245690129);
            contacts.AddContact("BBB@gmail.com");
            contacts.AddContact(8904421829);
            contacts.AddContact("CCC@gmail.com");

            long phoneNumber = (long)contacts.GetContactDetails(luckyNumber);
            Console.WriteLine("\nSelected contact details: "+ phoneNumber);

            /* the type of value returned is unpredictable if you are using an object array.
             * 
             * if the same class is used to store different types of values, then type casting is a must to avoid compilation error due to incompatible type assignment
             * 
             * if a single instance of the class is used to store both the type of values, then there will be a run time exception.
             * 
             * These disadvantages can be solved by using generics.
             */

            Console.WriteLine("\nMessages are being sent to the contacts selected........\n");

            string result = mobileContacts.SendLuckyDrawMessage<long>(mobileNumber, "Lucky draw message sent as SMS to");

            Console.WriteLine(result); ;

            result = emailContacts.SendLuckyDrawMessage<string>(emailId, "Lucky draw message sent as SMS to");

            Console.WriteLine(result);
        }
    }
}

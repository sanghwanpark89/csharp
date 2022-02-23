using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class ContactDetails<T>  //Since you do not know what type would be passed as parameter to the class, you can use a common letter 'T' as the parameter name
    {
        public T[] Contacts { get; set; }
        //An object array to store any type of contacts i.e. phone numbers and the email ids

        public int Size { get; set; }
        //Size property is used to set the size of the array

        public int IndexNumber { get; set; }
        //Indexnumber is used to keep track of the index number while adding contacts into the object array.

        public ContactDetails(int size)
        {
            this.Contacts = new T[size];
            this.Size = size;
            this.IndexNumber = 0;
        }
        //The parameterized constructor to initialize all the instance variables

        public void AddContact(T contact)
        {
            if(IndexNumber < Size)
            {
                Contacts[IndexNumber++] = contact;
            }
        }

        //AddContactDetails() is used to add contacts to the object array using the index number

        public T GetContactDetails(int number)
        {
            return Contacts[number];
        }

        //GetContactDetails() returns the contact present at the index number passed as a parameter
        //You can see that the parameter will be used as index number to select a contact from the object array and also returns the selected object

        public string SendLuckyDrawMessage<U>(U phoneNumber, string message)
        {
            string resultMessage = "Could not find the contact";

            T temp;

            for(int i = 0; i < this.Contacts.Length; i++)
            {
                temp = Contacts[i];
                if (temp.Equals(phoneNumber))
                {
                    resultMessage = message + " " + temp.ToString();
                    break;
                }
            }
            return resultMessage;
        }

        /*
         * Use the letter 'U' as the parameter to accept the data type.
         * Now replace the long data type with the letter U.
         */

        //public string SendLuckyDrawMessage(string emailId, string message)
        //{
        //    string resultMessage = "Could not find the contact";

        //    T temp;

        //    for(int i = 0; i < this.Contacts.Length; i++)
        //    {
        //        temp = Contacts[i];
        //        if (temp.Equals(emailId))
        //        {
        //            resultMessage = message + " " + temp.ToString();
        //            break;
        //        }
        //    }
        //    return resultMessage;

        //}



    }
}

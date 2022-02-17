using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 1;
            string dayString;

            switch (day)
            {
                case 1:
                    dayString = "Sunday";
                    break;
                case 2:
                    dayString = "Monday";
                    break;
                case 3:
                    dayString = "Tuesday";
                    break;
                case 4:
                    dayString = "Wednesday";
                    break;
                case 5:
                    dayString = "Thursday";
                    break;
                case 6:
                    dayString = "Friday";
                    break;
                case 7:
                    dayString = "Saturday";
                    break;
                default:
                    dayString = "Invalid day";
                    break;
            }

            Console.WriteLine(dayString);

            //The anser for above code is Monday.

            //switch (day)
            //{
            //    case 1:
            //        dayString = "Sunday";

            //    case 2:
            //        dayString = "Monday";
            //        break;
            //    case 3:
            //        dayString = "Tuesday";
            //        break;
            //    case 4:
            //        dayString = "Wednesday";
            //        break;
            //    case 5:
            //        dayString = "Thursday";
            //        break;
            //    case 6:
            //        dayString = "Friday";
            //        break;
            //    case 7:
            //        dayString = "Saturday";
            //        break;
            //    default:
            //        dayString = "Invalid day";
            //        break;
            //}
            //Console.WriteLine(dayString);

            /* The above code results in compilation error.
             * If any statement is written inside switch case then break statement is mandatory.
             */
        }
    }
}

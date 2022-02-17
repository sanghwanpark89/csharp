using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] courses = { "Basic C# Programming", "Advanced C# Programming", "SQL Server" };

            String[] courses = new String[3];
            //The array is created and courses variable will have array address

            courses[0] = "Basic C# Programming";
            courses[1] = "Advanced C# Programming";
            courses[2] = "SQL Server";

            //First array is same with Second array.
            //foreach is used to loop through each item in the array

            // foreach (var item in collection)
            // {
            //     // statements
            // }

            // where 'var item' - is the local variable similar to 'int item'
            // this variable is local to the foreach loop
            // collection is the name of the array

            Console.WriteLine("This is about the foreach loop");
            foreach(string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine();
            Console.WriteLine("This is about the for loop");

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            /*
             * For every iteration the value of the current array element of courses
             * is assigned to the local variable course until the end of the array is reached
             */
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myTwoDi = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; 

            //2D array syntax - int[row, column]

            for(int i = 0; i < 3; i++)//Row
            {
                for(int j = 0; j < 3; j++)//Column
                {
                    Console.Write(myTwoDi[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("myTwoDi total number: {0}", myTwoDi.Length) ;
            //Length property of array gives the total elements that can be contained in all the dimensions of the array.
        }
    }
}

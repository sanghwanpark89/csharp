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
            Category catObj = new Category();
            catObj[0] = 1001;
            //catObj[0] means, In category.cs the index variable will get the value 0. 
            //As you are trying to set the value you should go to the set accessor of the indexer
            //Go to the set accessor where you have an if-else condition
            //In this case the if condition in the set accessor gets satisfied because index value equals to zero
            //so the value gets unboxed and get assigned to the categoryId

            catObj[1] = "Mobiles";

            Console.WriteLine(catObj[0]);
            Console.WriteLine(catObj[1]);

            Employee empObj = new Employee();

            empObj[0] = 12341234;
            empObj[1] = "SangHwan";

            Console.WriteLine(empObj[0]);
            Console.WriteLine(empObj[1]);

        }
    }
}

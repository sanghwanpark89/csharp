using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//break is used to break out of the loop from the current point
//continue is used to jump out of the current loop condition into the next loop iteration

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                if(i%2 == 0)
                {
                    continue;
                }

                else
                {
                    for(int j = 1; j <= 10; j++)
                    {
                        if(j != i)
                        {
                            Console.WriteLine(j);
                        }
                        else
                        {
                            break;
                            /*
                             * The control after break goes out of the current loop(the inner for loop).
                             * In this case the control jumps out of the inner loop
                             * and continues with the next statement execution -here it is the outer for loop
                             * statements
                             */
                        }
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}

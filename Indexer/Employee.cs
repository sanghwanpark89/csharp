using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Employee
    {
        private int empNumber;
        private string empName;

        public object this[int index]
        {
            set
            {
                if(index == 0)
                {
                    this.empNumber = (int)value;
                }
                else if(index == 1)
                {
                    this.empName = value.ToString();
                }
            }

            get
            {
                if(index == 0)
                {
                    return this.empNumber;
                }
                else if(index == 1)
                {
                    return this.empName;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

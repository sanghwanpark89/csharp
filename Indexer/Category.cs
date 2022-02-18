using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Category
    {
        private int categoryId;
        private string categoryName;
        public object this[int index]
        {
            set
            {
                if (index == 0)
                    this.categoryId = (int)value;
                else if (index == 1)
                    this.categoryName = value.ToString();
            }
            get
            {
                if (index == 0)
                    return this.categoryId;
                else if (index == 1)
                    return this.categoryName;
                else
                    return 0;
            }
        }

    }
}

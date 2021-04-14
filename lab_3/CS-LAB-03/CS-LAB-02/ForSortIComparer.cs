using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_LAB_02
{
    class ForSortIComparer<T> : IComparer<T> where T:PC
    {
        public int Compare(T x, T y)
        {
            if (x.ROM.Count > y.ROM.Count)
            {
               // x.ROM[3].
                return 1;
            }
            if (x.ROM.Count < y.ROM.Count)
            {
                return -1;
            }
            else return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask_02
{
    public class myClass
    {
        public void Swap<T>(ref T First, ref T Second)
        {
            T tmp1 = First;
            First=Second; Second=tmp1;
        }
    }

}

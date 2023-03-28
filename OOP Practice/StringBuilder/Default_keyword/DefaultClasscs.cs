using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_keyword
{

    public  class GetDefaultClass<T>
    {
        public T GetDefault() {return default(T);}
    }
    public class MyGenericClass<T>
    {
        private T _value = default(T);
    }
}










using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExample
{
    using System;

    class MyObject : ICloneable
    {
        public int Number { get; set; }
        public string Text { get; set; }

        public MyObject(int number, string text)
        {
            Number = number;
            Text = text;
        }

        public object Clone()
        {
            return new MyObject(Number, Text);
        }
    }

}

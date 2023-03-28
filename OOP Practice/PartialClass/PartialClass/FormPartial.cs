using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public  partial class Form
    {
        private string _name;
        private string _email;
        private string _password;

        public Form()
        {
            _email = string.Empty;
            _name = string.Empty;
            _password = string.Empty;
        }
        public void Reset()
        {
            _email = string.Empty;
            _name = string.Empty;
            _password = string.Empty;
        }      
    }
}







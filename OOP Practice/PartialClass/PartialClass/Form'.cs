using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public  partial class Form
    {
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetPassword(string password)
        {
            _password = password;
        }
        public void SetEmail(string email)
        {
            _email = email;
        }
    }
}






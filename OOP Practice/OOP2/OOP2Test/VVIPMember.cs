using OOP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Test
{
    public  class VVIPMember : VIPMember 
    {
        public VVIPMember(int id) : base(id)
        {
            HashValue="ABDCD";
        }
    }
}

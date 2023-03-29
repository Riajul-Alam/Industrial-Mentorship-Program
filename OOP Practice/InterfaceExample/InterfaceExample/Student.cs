using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Student:IInformation
    {
        public int RegNo { get; set; }
        public int Name { get; set; }
        public int Roll { get; set; }
        public int Email { get; set; }

        public string GetBasicInformation()
        {
            return "RegNo : "+RegNo+" Name : "+Name+" Roll : "+Roll;
        }
    }
}

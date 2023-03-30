using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Interface
{
    public class Team:IEnumerable
    {
        private Player[] player=new Player[10];
        public Team()
        {
            player[0]=new Player("Tamim",34);
            player[1]=new Player("Mushfique",35);
            player[2]=new Player("Mahmudullah",37);
            player[3]=new Player("Mashrafee",38);
        }

        public IEnumerator GetEnumerator()
        {
            return player.GetEnumerator();
        }
    }
}

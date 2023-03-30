using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Interface2
{
    public class OrganizationEnumerator : IEnumerator
    {
        Organization OrgColl;
        int CurrentIndex;
        Employee CurrentEmployee;
        public OrganizationEnumerator(Organization org)
        {
            OrgColl = org;
            CurrentIndex = -1;
        }
        public object Current
        {
            get
            {
                return CurrentEmployee;
            }
        }

        public bool MoveNext()
        {
            if (++CurrentIndex>= OrgColl.Count)
            {
                return false;
            }
            else
            {
                CurrentEmployee= OrgColl[CurrentIndex];
            }
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

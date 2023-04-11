using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;

namespace ICollectionExample
{
    class MyCollection : ICollection
    {
        private ArrayList items = new ArrayList();

        public int Count
        {
            get { return items.Count; }
        }

        public bool IsSynchronized
        {
            get { return items.IsSynchronized; }
        }

        public object SyncRoot
        {
            get { return items.SyncRoot; }
        }

        public void Add(object item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public bool Contains(object item)
        {
            return items.Contains(item);
        }

        public void CopyTo(Array array, int index)
        {
            items.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public void Remove(object item)
        {
            items.Remove(item);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask_03
{
    public class Stack<T>
    {
        private readonly List<T> items;
        public Stack()
        {
            items = new List<T>();
        }
        public void Push(T item)
        {
            items.Add(item);
        }
        public void Pop()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Stack UnderFlow"); return;
            }
            items.RemoveAt(items.Count - 1);
        }
        public T Peek()
        {
            if (items.Count==0)
            {
                Console.WriteLine("Stack is Empty");
            }
            return items[items.Count - 1];
        }
    }
}




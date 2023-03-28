using System;

Stack<int> st = new Stack<int>();
st.Push(0);
st.Push(1);
st.Push(2);
st.Push(3);
st.Push(4);
Console.WriteLine(st.Count);
st.Pop();
Console.WriteLine(st.Count);
Console.WriteLine(st.Peek());
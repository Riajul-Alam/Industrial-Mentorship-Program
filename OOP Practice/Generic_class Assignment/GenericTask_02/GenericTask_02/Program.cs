using System;

using GenericTask_02;



void Swap<T>(ref T First, ref T Second)
{
    T tmp1 = First;
    First=Second; Second=tmp1;
}


string? S, T;
S=Console.ReadLine();
T=Console.ReadLine();
Swap(ref S, ref T);

Console.WriteLine(S+" "+T);







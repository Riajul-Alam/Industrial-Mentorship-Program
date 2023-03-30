using System;
using System.Collections;
using IEnumerable_Interface;

public class Program
{
    public static void Main(string[] args)
    {
        Team obj = new Team();
        foreach (Player player1 in obj)
        {
            Console.WriteLine(player1.Name+" "+player1.Age);
        }
    }
}
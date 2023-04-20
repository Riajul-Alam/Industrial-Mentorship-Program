/*
using System.IO;

string filePath = @"F:\1.web development\C# and .Net core\C# program\Information.txt";
FileInfo fileInfo = new FileInfo(filePath);

Console.WriteLine("File name: " + fileInfo.Name);
Console.WriteLine("File size: " + fileInfo.Length);
Console.WriteLine("Last modified: " + fileInfo.LastWriteTime);



*//*string filePath = @"F:\1.web development\C# and .Net core\C# program\Information.txt";
FileInfo fileInfo = new FileInfo(filePath);
Console.WriteLine($"File name: {fileInfo.Name}");
Console.WriteLine($"File length: {fileInfo.Length} bytes");
Console.WriteLine($"Last write time: {fileInfo.LastWriteTime}");


// Use a raw string literal for the file path
FileInfo fi = new FileInfo($@"F:\1.web development\C# and .Net core\C# program\TestFile_Dpk1.txt");
using StreamWriter str = fi.CreateText();
Console.WriteLine("File has been created");
Console.ReadLine();

using System;
using System.IO;
class Example2
{
    static void Main()
    {
        FileInfo info1 = new FileInfo($@"F:\1.web development\C# and .Net core\C# program\hel1.txt");
        DateTime time = info1.CreationTime;
        Console.WriteLine(time);
        time = info1.LastAccessTime;
        Console.WriteLine(time);
        time = info1.LastWriteTime;
        Console.WriteLine(time);
    }
}*/

using System.IO;

string filePath = "D:\\example.txt";
FileInfo fileInfo = new FileInfo(filePath);

Console.WriteLine("File name: " + fileInfo.Name);
Console.WriteLine("File size: " + fileInfo.Length);
Console.WriteLine("Last modified: " + fileInfo.LastWriteTime);

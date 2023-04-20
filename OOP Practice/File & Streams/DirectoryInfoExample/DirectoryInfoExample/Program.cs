using System;
using System.IO;

// Create Directory
string path = "F:\\1.web development\\C# and .Net core\\C# program\\MyTestFile1";
DirectoryInfo fl = new DirectoryInfo(path);
fl.Create();

// subDirectory 
DirectoryInfo dis = fl.CreateSubdirectory("MyTestFile2");

// directory Info
DirectoryInfo directoryInfo = new DirectoryInfo(path);

if (directoryInfo.Exists)
{
    Console.WriteLine("Directory name: " + directoryInfo.Name);
    Console.WriteLine("Number of files: " + directoryInfo.GetFiles().Length);
    Console.WriteLine("Number of subdirectories: " + directoryInfo.GetDirectories().Length);
    Console.WriteLine("Last write time: " + directoryInfo.LastWriteTime);
}
else
{
    Console.WriteLine("The directory does not exist.");
}



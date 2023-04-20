using System;
using System.IO;


//Reading from a file
string path = "F:\\1.web development\\C# and .Net core\\C# program\\MyTestFile1\\New Text Document.txt";
string fileContents = File.ReadAllText(path);
Console.WriteLine("File contents:");
Console.WriteLine(fileContents);


//Writing to a file
string fileContents1 = "This is an example of writing to a file.";
File.WriteAllText(path, fileContents1);
Console.WriteLine("File written.");

//Appending to a file
string fileContents2 = "This is an example of appending to a file.";
File.AppendAllText(path, fileContents2);
Console.WriteLine("File appended.");
fileContents = File.ReadAllText(path);
Console.WriteLine("File contents:");
Console.WriteLine(fileContents);








using System.Text;



//Create a file
string path = "F:\\1.web development\\C# and .Net core\\C# program\\TestFile.txt";
FileStream fs = File.Create(path);

//Open a File
string path1= "F:\\1.web development\\C# and .Net core\\C# program\\TestFile.txt";
FileStream fs1 = File.Open(path1,FileMode.Open);

// create a file at path and write "Hello World" to the file
File.WriteAllText(path1, "Hello World");

// read the content of TestFile.txt file
string readText = File.ReadAllText(path1);
Console.WriteLine(readText);





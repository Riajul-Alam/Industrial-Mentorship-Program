

//Reading from a stream
string path = "F:\\1.web development\\C# and .Net core\\C# program\\MyTestFile1\\New Text Document.txt";
using (StreamReader reader = new StreamReader(path))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}


//Writing to a stream
string filePath = "F:\\1.web development\\C# and .Net core\\C# program\\MyTestFile1\\New Text Document.txt";
using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine("This is an example of writing to a stream.");
}
Console.WriteLine("Data written.");

//FileStream

using (FileStream f = new FileStream(filePath, FileMode.Open))
{
    Console.WriteLine("File opened");
    f.WriteByte(85);
    Console.WriteLine("Data written into file");
}







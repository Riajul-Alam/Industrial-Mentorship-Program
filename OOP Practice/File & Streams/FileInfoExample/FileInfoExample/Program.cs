using System.IO;


// Create file 
string path = "F:\\1.web development\\C# and .Net core\\C# program\\Information.txt";
FileInfo fileInfo = new FileInfo(path);
fileInfo.Create();
{
    Console.WriteLine("File has been created");
}

// file Information
string filePath1 = "F:\\1.web development\\C# and .Net core\\C# program\\Information.txt";
FileInfo fileInfo1 = new FileInfo(filePath1);

Console.WriteLine("File name: " + fileInfo.Name);
Console.WriteLine("File size: " + fileInfo.Length);
Console.WriteLine("Creation Time "+fileInfo.CreationTime);
Console.WriteLine("Last modified: " + fileInfo.LastWriteTime);

//File Directory Information
FileInfo info_new = new FileInfo("F:\\1.web development\\C# and .Net core\\C# program\\Information.txt");
DirectoryInfo dir = info_new.Directory;
Console.WriteLine(dir.Name);
string name = info_new.DirectoryName;
Console.WriteLine(name);

// File Exists or not check
string filePath2 = "F:\\1.web development\\C# and .Net core\\C# program\\Information.txt";
FileInfo fileInfo2 = new FileInfo(filePath2);

if (fileInfo2.Exists)
{
    Console.WriteLine("The file exists.");
}
else
{
    Console.WriteLine("The file does not exist.");
}

// Renaming a file
string filePath3 = "F:\\1.web development\\C# and .Net core\\C# program\\Information4.txt";
FileInfo fileInfo3 = new FileInfo(filePath3);

if (fileInfo3.Exists)
{
    string newFilePath = "F:\\1.web development\\C# and .Net core\\C# program\\New_Information.txt";
    fileInfo3.MoveTo(newFilePath);
    Console.WriteLine("The file has been renamed.");
}
else
{
    Console.WriteLine("The file does not exist.");
}

/*// copying a file
string sourceFilePath = "F:\\1.web development\\C# and .Net core\\C# program\\file1.txt";
string destFilePath = "G:\\tmp.txt";

FileInfo sourceFileInfo = new FileInfo(sourceFilePath);

if (sourceFileInfo.Exists)
{
    sourceFileInfo.CopyTo(destFilePath);
    Console.WriteLine("The file has been copied.");
}
else
{
    Console.WriteLine("The source file does not exist.");
}*/

// Delete File
string filePath4 = "F:\\1.web development\\C# and .Net core\\C# program\\tmp.txt";
FileInfo fileInfo4 = new FileInfo(filePath4);

if (fileInfo4.Exists)
{
    fileInfo4.Delete();
    Console.WriteLine("The file has been deleted.");
}
else
{
    Console.WriteLine("The file does not exist.");
}











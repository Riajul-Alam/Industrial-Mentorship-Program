using System.IO;

string path = "F:\\1.web development\\C# and .Net core\\C# program\\MyTestFile1";

if (!Directory.Exists(path))
{
    Directory.CreateDirectory(path);
    Console.WriteLine("The directory has been created.");
}

// create a subdirectory
path="F:\\1.web development\\C# and .Net core\\C# program\\MyTestFile1\\MyTestFile2";
if (!Directory.Exists(path))
{
    Directory.CreateDirectory(path);
    Console.WriteLine("The subdirectory has been created.");
}

// delete all files
if (Directory.Exists(path))
{
    string[] fileNames = Directory.GetFiles(path);

    foreach (string fileName in fileNames)
    {
        File.Delete(fileName);
    }

    Console.WriteLine("All files in the directory have been deleted.");
}



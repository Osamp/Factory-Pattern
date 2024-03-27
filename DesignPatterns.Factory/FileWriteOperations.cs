using System.IO;
namespace DesignPatterns.Factory;

public class FileWriteOperation : IFileOperation
{
    public void Execute(string filepath)
    {
        Console.WriteLine("Please type your text below");
        string content = Console.ReadLine();
        File.WriteAllText(filepath, content);
        Console.WriteLine("Content written to file");
}
}
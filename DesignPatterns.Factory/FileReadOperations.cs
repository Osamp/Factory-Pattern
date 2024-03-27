namespace DesignPatterns.Factory;

using System;

public class FileReadOperation : IFileOperation
{
    public void Execute(string filepath)
    {
        string content = File.ReadAllText(filepath);
        Console.WriteLine(content);
    }
}
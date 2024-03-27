using DesignPatterns.Factory;

Console.WriteLine("Please type a command: (read, write)");
string? command = Console.ReadLine();

var operation = FileOperationFactory.CreateOperation(command ?? "");

Console.WriteLine("PLease enter a file path");
string? file = Console.ReadLine();

operation.Execute(file ?? "");
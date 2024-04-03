﻿// using DesignPatterns.Factory;

// Console.WriteLine("Please type a command: (read, write)");
// string? command = Console.ReadLine();

// var operation = FileOperationFactory.CreateOperation(command ?? "");

// Console.WriteLine("PLease enter a file path");
// string? file = Console.ReadLine();

// operation.Execute(file ?? "");

using DesignPatterns.Observer;

var subject = new Subject<string>();
var obs1 = new UpperCaseObserver();
var obs2 = new LowerCaseObserver();

subject.Subscribe(obs1);
subject.Subscribe(obs2);

subject.Value = Console.ReadLine() ?? "";

Console.ReadLine();
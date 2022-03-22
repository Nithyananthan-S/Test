// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using Test;

Console.WriteLine("Hello, World!");
Console.WriteLine("Test");
var s = "test2";
Console.WriteLine($"selected {s}"); 
Console.ReadLine();
BenchmarkRunner.Run<BenchmarkStringIntialization>();
Console.ReadLine();
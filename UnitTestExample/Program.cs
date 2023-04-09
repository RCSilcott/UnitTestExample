// See https://aka.ms/new-console-template for more information
using UnitTestExample;

Console.WriteLine("Hello, World!");

var _ProgramService = new ProgramService();

int num = Convert.ToInt32(Console.ReadLine());

int result = _ProgramService.Square(num);

Console.WriteLine($"{num} squared equals {result}");
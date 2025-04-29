using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your  Firstname?");
        string first_name = Console.ReadLine();
        Console.Write("What is your  Lastname?");
        string last_name = Console.ReadLine();
        Console.WriteLine($"My name is {last_name}, {first_name} {last_name}");


    }
}
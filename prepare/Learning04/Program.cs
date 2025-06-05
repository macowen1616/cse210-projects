using System;
using library_demo;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment();
        math1.SetName("Smith");
        math1.SetTextbookSection("5.2");
        math1.SetProblems("1-10 even");

        Console.WriteLine(math1.GetMathInfo());


        Writing writing1 = new Writing();
        writing1.SetTitle("Gone with the Wind");
    }
}

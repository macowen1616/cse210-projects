using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

         Console.WriteLine("What was your score?");
        string valueFromUser = Console.ReadLine();

        int score;
        if (int.TryParse(valueFromUser, out score))
        {
            if (score >= 90)
            {
                Console.WriteLine("You got an A!");
            }
            else if (score >= 80)
            {
                Console.WriteLine("You got a B!");
            }
            else if (score >= 70)
            {
                Console.WriteLine("You got a C!");
            }
            else if (score >= 60)
            {
                Console.WriteLine("You got a D!");
            }
            else
            {
                Console.WriteLine("You got an F.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }}
using System;
using System.Collections.Generic;

public class ListeningActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListeningActivity() : base("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many as you can.")
    { }

    public void PerformActivity()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        int duration = GetDuration();

        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nList as many responses as you can to the following prompt:\n>>> {prompt} <<<");
        Console.WriteLine("You may begin in:");
        Countdown(5);

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        DisplayEndingMessage();
    }
}

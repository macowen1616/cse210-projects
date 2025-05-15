class PromptGenerator
{
    private List<string> Prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private Random rand = new Random();

    public string GetRandomPrompt()
    {
        int index = rand.Next(Prompts.Count);
        return Prompts[index];
    }
}
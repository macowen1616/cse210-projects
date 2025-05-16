class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public void Display()
    {
        Console.WriteLine($"{Date} - {Prompt}\n{Response}\n");
    }
}

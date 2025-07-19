using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address addr2 = new Address("456 Park Ave", "Reno", "NV", "USA");
        Address addr3 = new Address("789 Beach Blvd", "San Diego", "CA", "USA");

        Event lecture = new Lecture("AI Conference", "Discussing the future of AI", "Aug 20", "10:00 AM", addr1, "Dr. Jane Smith", 150);
        Event reception = new Reception("Tech Mixer", "Networking for tech professionals", "Sep 5", "6:00 PM", addr2, "rsvp@techmixer.com");
        Event outdoor = new OutdoorGathering("Beach Bonfire", "End of summer beach party", "Aug 30", "7:00 PM", addr3, "Clear skies and 75°F");

        Event[] events = { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("----- Standard Details -----");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine("\n----- Full Details -----");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine("\n----- Short Description -----");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("\n===============================\n");
        }
    }
}

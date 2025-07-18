using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Cook Pasta", "Chef Makay", 300);
        video1.AddComment(new Comment("Alice", "This was so helpful, thanks!"));
        video1.AddComment(new Comment("Bob", "Now I'm hungry lol."));
        video1.AddComment(new Comment("Charlie", "Tried this today and loved it!"));
        videos.Add(video1);

        Video video2 = new Video("Extreme Airsoft", "Sierra Nevada Rangers", 540);
        video2.AddComment(new Comment("Dave", "Can’t wait to go Airsofting now."));
        video2.AddComment(new Comment("Eve", "Those BBs were flying like crazy!!"));
        video2.AddComment(new Comment("Frank", "Awesome!"));
        videos.Add(video2);

        Video video3 = new Video("Learn C# in 10 Minutes", "CodeMaster", 600);
        video3.AddComment(new Comment("George", "Great crash course!"));
        video3.AddComment(new Comment("Hannah", "Very clear explanations."));
        video3.AddComment(new Comment("Isaac", "Wish I saw this earlier."));
        videos.Add(video3);

        Video video4 = new Video("Top 10 most Dangerous Animals", "Animal Planet", 180);
        video4.AddComment(new Comment("Jake", "Soooo Dangerous!"));
        video4.AddComment(new Comment("Lily", "Some are really cute!"));
        video4.AddComment(new Comment("Mia", "We have to watch out!"));
        videos.Add(video4);

        foreach (Video vid in videos)
        {
            vid.DisplayVideoInfo();
        }
    }
}

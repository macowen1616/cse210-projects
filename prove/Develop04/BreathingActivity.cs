using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.")
    { }

    public void PerformActivity()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        int cycleTime = 6; 
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("Breathe in...");
            Countdown(3);
            elapsed += 3;

            Console.Write("Breathe out...");
            Countdown(3);
            elapsed += 3;
        }

        DisplayEndingMessage();
    }
}

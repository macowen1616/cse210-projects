using System;

public class BikingAct : Activity
{
    private double speed;

    public override void PerformActivity()
    {
        // Hardcoded or could ask user for input
        date = new DateTime(2022, 11, 3);
        durationMinutes = 30;
        speed = 6.0;

        Console.WriteLine(GetSummary());
    }

    public override double GetDistance()
    {
        return speed * (durationMinutes / 60.0);
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }

    public override string GetSummary()
    {
        return $"{date:dd MMM yyyy} Biking ({durationMinutes} min)- " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}

using System;

public class RunningAct : Activity
{
    private double speed;
public override void PerformActivity()
    {
        Console.Write("Enter the date (yyyy-mm-dd): ");
        date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the duration in minutes: ");
        durationMinutes = int.Parse(Console.ReadLine());

        Console.Write("Enter your average speed in mph: ");
        speed = double.Parse(Console.ReadLine());

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
        return $"{date:dd MMM yyyy} Running ({durationMinutes} min)- " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}
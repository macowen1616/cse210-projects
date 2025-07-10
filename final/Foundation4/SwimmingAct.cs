using System;

public class SwimmingAct : Activity
{
    private int laps; 

    public SwimmingAct()
    {
        
    }

    public override void PerformActivity()
    {
        Console.Write("Enter the date (yyyy-mm-dd): ");
        date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the duration in minutes: ");
        durationMinutes = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of laps swum (each lap is 50m): ");
        laps = int.Parse(Console.ReadLine());

        Console.WriteLine(GetSummary());
    }

    public override double GetDistance()
    {
        
        return laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        
        return (GetDistance() / durationMinutes) * 60.0;
    }

    public override double GetPace()
    {
        
        return durationMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{date:dd MMM yyyy} Swimming ({durationMinutes} min)- " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}



using System;

public abstract class Activity
{
    protected DateTime date;
    protected int durationMinutes;

    public abstract void PerformActivity(); // Enforce implementation in derived classes

    public abstract double GetDistance(); 
    public abstract double GetSpeed();    
    public abstract double GetPace();     

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} Activity ({durationMinutes} min)";
    }
}



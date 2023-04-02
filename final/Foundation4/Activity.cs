using System;
public class Activity
{
    private DateTime date;
    private int duration;

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{date.ToString("MMMM dd, yyyy")} ({duration} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace {GetPace():F1} min per mile";
    }

    public DateTime Date
    {
        get { return date; }
        set { date = value; }
    }

    public int Duration
    {
        get { return duration; }
        set { duration = value; }
    }
}

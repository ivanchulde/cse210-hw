public abstract class Activity
{
    private DateTime _dateActivity;
    private int _durationActivity;

    public Activity(DateTime date, int duration)
    {
        _dateActivity = date;
        _durationActivity = duration;
    }

    public DateTime GetDate()
    {
        return _dateActivity;
    }

    public int GetDurationActivity()
    {
        return _durationActivity;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_dateActivity.ToString("dd MMM yyyy")} {this.GetType().Name} ({_durationActivity} min): " +
               $"Distance {GetDistance():0.##} miles, Speed: {GetSpeed():0.##} mph, Pace: {GetPace():0.##} min per mile";
    }

  
}
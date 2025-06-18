public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62; // Convert to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDurationActivity()) * 60;
    }

    public override double GetPace()
    {
        return GetDurationActivity() / GetDistance();
    }
}

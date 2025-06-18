public class Cycling : Activity
{
    private double _speed; // mph

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetDurationActivity()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}

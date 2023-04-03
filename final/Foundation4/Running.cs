public class Running : Activity
{
    protected double _distance;

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_length / 60.0);
    }

    public override double GetPace()
    {
        return (_length / _distance) * 60.0;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min)- Distance {_distance} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
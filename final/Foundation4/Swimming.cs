public class Swimming : Activity
{
    int _laps;
    
    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_length / 60.0);
    }

    public override double GetPace()
    {
        return (_length / _laps) * 50.0 / 60.0;
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
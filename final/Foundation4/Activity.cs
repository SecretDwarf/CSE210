public abstract class Activity
{
    protected string _date { get; set; }
    protected int _length { get; set; }

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public abstract string GetSummary();
}


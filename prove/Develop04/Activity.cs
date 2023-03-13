public abstract class Activity
{
    string _activityName;
    string _description;
    protected int _time;
    Timer _timer = new Timer(0, "");

    public Activity(string name, string desc);
    {
        _activityName = name;
        _description = desc;
        GetTime();
    }

    public void GetTime()
    {
        IO.Write($"{_activityName}: {_description}", true);
        IO.Write("----------------------------------------------------------------------", true);
        try
        {
            _time = int.Parse(IObservable.Read("How many seconds do you want to preform this activity? "))
        }
        catch (System.Exception)
        {
            IO.Write("Invalid REsponse", true);
            GetTime();
        }
    }

    public void PrepareToBegin()
    {
        _timer = new Timer(3, "Prepare to begin");
        _timer.CountDown();
    }

    public void CoolDown()
    {
        IO.Write($"Good job! You have completed the {activyName} for {_time} seconds", true);

        _timer = Timer(3, "Time to cool down.");
        _timer.CoolDown();
    }

    public abstract void DoActivity();
}
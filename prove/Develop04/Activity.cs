public abstract class Activity
{
    string _activityName;
    string _description;
    protected int _time;
    Timer _timer = new Timer(0, "");

    public Activity(string name, string desc)
    {
        _activityName = name;
        _description = desc;
        GetTime();
    }

    public void GetTime()
    {
        Console.Write($"{_activityName}: {_description}", true);
        Console.Write("----------------------------------------------------------------------", true);
        try
        {
            Console.Write("How many seconds do you want to preform this activity? ");
            _time = int.Parse(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.Write("Invalid Response", true);
            GetTime();
        }
    }

    public void PrepareToBegin()
    {
        _timer = new Timer(3, "Prepare to begin ");
        _timer.CountDown();
    }

    public void CoolDown()
    {
        Console.Write($"Good job! You have completed the {_activityName} for {_time} seconds", true);

        _timer = new Timer(3, "Time to cool down. ");
        _timer.CountDown();
    }

    public abstract void DoActivity();
}
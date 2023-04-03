public class ActivityBreathing : Activity
{
    Timer _t = new Timer(0,"");
    int _breatheInTime = 5;
    int _breatheOutTime = 5;
    public ActivityBreathing(string name, string desc) :base(name,desc)
    {
    }

    public override void DoActivity()
    {
        PrepareToBegin();
        int countDownTime = _time;
        // Console.WriteLine(countDownTime);
        while(countDownTime>0)
        {
            _t = new Timer(_breatheInTime, "Breathe In...");
            _t.Animation(0);
            _t = new Timer(_breatheOutTime, "Breathe Out...");
            _t.Animation(2);

            countDownTime -= (_breatheInTime + _breatheOutTime);
        }
        CoolDown();
    }
    
}
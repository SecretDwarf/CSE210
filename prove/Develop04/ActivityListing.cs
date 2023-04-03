public class ActivityListing : Activity
{
    Timer _t;
    int _promptTime = 3;
    int _reflectionTime = 3;
    List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are some good things about today?",
        "What are you greatful for?",
        "How have you recognized the Lord's hand in you life this week? What can you do to look better?",
        "What is something kind you've done recently?",
        "What are some constructive things you can do to be better?"
    };

    public ActivityListing(string name, string desc) :base(name,desc)
    {
    }

    public override void DoActivity()
    {
        PrepareToBegin();
        int countDownTime = _time;

        Timer timer = new Timer(_promptTime,$"{ShowPrompt()}");
        timer.CountDown();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);

        Console.Write("Type as many responses as you can.", true);
        DateTime currentTime = DateTime.Now;     
        while(currentTime < futureTime)
        {
            Console.Read();
            currentTime = DateTime.Now;
        }
        CoolDown();
    }

    private string ShowPrompt()
    {
        Random rand = new Random();
        int next = rand.Next(0, _prompts.Count());
        return _prompts[next];
    }

}
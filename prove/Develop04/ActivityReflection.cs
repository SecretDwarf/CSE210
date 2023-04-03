public class ActivityReflection : Activity
{
    public ActivityReflection(string name, string desc) :base(name,desc)
    {
    }

    Timer _t;
    int _promptTime = 3;
    int _reflectionTime = 3;
    List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "What are some good things about today?",
        "What are you greatful for?",
        "How have you recognized the Lord's hand in you life this week? What can you do to look better?",
        "What is something kind you've done recently?",
        "What are some constructive things you can do to be better?"
    };

    List<string> _reflections = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "How did this expirence make you feel?",
        "What charecter trait does this expirence encourage?",
        "What part of your expirence with this situation could you learn from?",
        "How does your memory of this expirence make you feel?"
    };

    public override void DoActivity()
    {
        PrepareToBegin();
        int countDownTime = _time;

        Timer timer = new Timer(_promptTime,$"{ShowPrompt()}");
        timer.CountDown();
        while(countDownTime>0)
        {
            _t = new Timer(_reflectionTime,ShowReflection());
            _t.Animation(0);
            countDownTime -= (_reflectionTime);
        }
        CoolDown();
    }
    private string ShowPrompt()
    {
        Random rand = new Random();
        int next = rand.Next(0, _prompts.Count());
        return _prompts[next];
    }
        private string ShowReflection()
    {
        Random rand = new Random();
        int next = rand.Next(0, _reflections.Count());
        return _reflections[next];
    }
}
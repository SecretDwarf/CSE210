public class Timer
{
    int _time;
    string _message;
    List<string> spinner = new List<string>{
        "/|\\-",
        "~-",
        "(U)C"
    };
    int _spinnerPos = 0;

    public Timer (int time, string message)
    {
        _message = message;
        _time = time;
    }

    public void CountDown()
    {
        Console.Write(_message, true);
        for(int i = _time; i>0;i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write($"\b");
        }

    }

    public void Animation(int animation)
    {
        char[] myString = spinner[animation].ToCharArray();
        Console.WriteLine(_message, true);

        for(int j = 0; j<(_time*2); j++){
            Console.Write($"{myString[_spinnerPos%myString.Count()]}");
            Thread.Sleep(500);
            (int,int) pos = Console.GetCursorPosition();
            // Console.SetCursorPosition(0,pos.Item2);
            Console.Write($"\b\b");
            _spinnerPos++;
        }
    }
}
public class Prompt
{
    List<string> _promptList = new List<string>();
    Random RandomPrompt = new Random();
    public Prompt()
    {
        _promptList.Add("What's something good that happened today? ");
        _promptList.Add("What's something kind you saw someone do today? ");
        _promptList.Add("What's something you can do to improve for tomorrow that you did today? ");
        _promptList.Add("What's something that made today unique? ");
        _promptList.Add("What's something that you've done recently for yourself? ");
        _promptList.Add("What's something that you could tomorrow to help someone? ");
        _promptList.Add("What's something that you want to have in the future? What can you do in the next 24 hours to get there? ");
        _promptList.Add("What's something that you want to do better? How are you going to measure your successes and shortcomings? ");
        _promptList.Add("Who was the most interesting person I interacted with today? ");
        _promptList.Add("What was the best part of my day? ");
        _promptList.Add("How did I see the hand of the Lord in my life today? ");
        _promptList.Add("What was the strongest emotion I felt today? ");
        _promptList.Add("If I had one thing I could do over today, what would it be? ");
        _promptList.Add("What's something that happened today that I can find something good to focus on? ");
        _promptList.Add("What's something I'm looking forward too. What can I do to have more joy in my life? ");
        _promptList.Add("What's something simple I can do tomorrow that wil make someone feel appreciated? ");
        _promptList.Add("Who is someone that I see as a blessing in my life? ");
        _promptList.Add("How can I better recognize blessings in my life? ");
        _promptList.Add("What am I doing to intentionally invite God into my life? ");
        _promptList.Add("How can I be better than I am today? ");
    }
    public string DisplayPrompt()
    {
        Console.Write("Prompt: ");
        int Index = RandomPrompt.Next(_promptList.Count);
        string Random = _promptList[Index];
        return Random;
    }
}
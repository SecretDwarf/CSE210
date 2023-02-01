public class Entry
{
    public string _entry = "";
    public string _prompt = "";
    public string _date = "";

    public Entry()
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
    }

    public void InsertEntry()
    {
        _prompt = new Prompt().GeneratePrompts();
        Console.WriteLine(_prompt);
        _entry = Console.ReadLine();
        Console.Write("Saved!");
    }
    public void displayPrompt()
    {
        Console.WriteLine($"{_date}: {_prompt}\n\t{_entry}");
    }

    public string stringfy()
    {
        return $"{_date} ||| {_prompt} ||| {_entry}";
    }

    public void createFromList(string[] entryDetails){
        _date=entryDetails[0];
        _prompt=entryDetails[1];
        _entry=entryDetails[2];
    }

}
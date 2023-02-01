public class Journal
{


    public List<Entry> _entries = new List<Entry>();


    public Journal() { }

    public string addEntry()
    {
        Entry entry = new Entry();
        entry.InsertEntry();
        _entries.Add(entry);
        return "Entry Added!";
    }

    public void displayEntry()
    {
        foreach (var entry in _entries)
        {
            entry.displayPrompt();
        }
        Console.WriteLine("Press enter to go back to Menu");
        Console.ReadLine();
    }

    public void LoadEntries(List<Entry> entries)
    {
        _entries = entries;
    }

    public List<Entry> getEntries()
    {
        return _entries;
    }
}
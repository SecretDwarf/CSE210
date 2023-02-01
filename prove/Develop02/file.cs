using System.IO;

public class journalFile
{

    public string _defaultFile = "journal.txt";

    public void writeFile(List<Entry> entries)
    {
        string filename = promptFileName($"File saving to ({_defaultFile}): ");
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                outputfile.WriteLine(entry.stringfy());
            }
        }
    }

    public string promptFileName(string prompt)
    {
        Console.Write(prompt);
        string filename = Console.ReadLine();
        filename = filename == string.Empty ? _defaultFile : filename;
        return filename;
    }

    public List<Entry> readFile()
    {
        string filename = promptFileName($"What file would you like to load({_defaultFile}): ");
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<Entry> entries = new List<Entry>();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|||");
            Entry e = new Entry();
            e.createFromList(parts);
            entries.Add(e);
        }
        return entries;
    }

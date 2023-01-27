using System.Text.Json;

namespace SerializeToFile
{
    public class JournalFile
    {
        public DateTimeOffset date { get; set; }
        public string chosenPrompt { get; set; }

        public string entry { get; set;}
    }

    public class Journal
    {
        public static void Main()
        {
            var Journal = new JournalFile()
            {
                date = 
                chosenPrompt = DisplayPrompt();
                entry = 
            };

            string fileName = date + ".json"; 
            string jsonString = JsonSerializer.Serialize(JournalFile);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}
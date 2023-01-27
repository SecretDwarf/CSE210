using System.Text.Json;

namespace SerializeToFile
{
    public class JournalFile
    {
        public DateTimeOffset Date { get; set; }
        public string ChosenPrompt { get; set; }

        public string entry { get; set;}
    }

    public class Program
    {
        public static void Main()
        {
            var Journal = new JournalFile()
            {
                Date = 
                ChosenPrompt = 
                entry = 
            };

            string fileName = "{date}.json"; 
            string jsonString = JsonSerializer.Serialize(JournalFile);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}
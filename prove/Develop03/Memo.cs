class Memo
{
    private Scripture scripture;

    public Memo(Scripture scripture)
    {
        this.scripture = scripture;
    }

    public void Start()
    {       

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.Reference);            
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to hide more words, or type 'quit' to exit");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            scripture.HideRandomWords();
            if (scripture.HiddenWords.All(x => x))
            {
                Console.Clear();
                Console.WriteLine(scripture.Reference);      
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("All words have been hidden!");
                break;
            }
        }
    }
}
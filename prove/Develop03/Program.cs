using System;


using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Memo game = new Memo(scripture);
        game.Start();
    }
}
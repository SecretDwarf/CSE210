using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Entry p = new Entry();
        Journal j = new Journal();
        journalFile file = new journalFile();
        string message = string.Empty;
        Menu(p, j, file);

        void Menu(Entry p, Journal j, journalFile file)
        {
            int choice = 0;
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 5)
            {
                Console.Write("See yah!");
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        message = j.addEntry();
                        Menu(p, j, file);

                        break;

                    case 2:
                        j.displayEntry();
                        Menu(p, j, file);

                        break;

                    case 3:
                        List<Entry> entries = file.readFile();
                        j.LoadEntries(entries);
                        message = "Loaded Entries Successfully";
                        Menu(p, j, file);

                        break;

                    case 4:
                        file.writeFile(j.getEntries());
                        message = "Saved File Successfully";
                        Menu(p, j, file);
                        break;
                        
                    default:
                        Console.WriteLine("Please enter a number 1-5.");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        Menu(p, j, file);
                        break;
                }

            }

        }
    }
}
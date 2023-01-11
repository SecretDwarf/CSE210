using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        bool guessed = false;
        int turns = 0;
        while (guessed == false)
        {
            turns += 1;
            Console.Write("Guess the magic number between 1 and 100. ");
            int answer = int.Parse(Console.ReadLine());
            if (answer > number)
            {
                Console.WriteLine("Guess Lower");
            }
            else if (answer < number)
            {
                Console.WriteLine("Guess Higher");
            }
            else
            {
                Console.WriteLine("Correct. Perfect. Great Job. You win!");
                Console.WriteLine($"You guessed {answer} after {turns} times.");
                guessed = true;
            }
        }
    }
}
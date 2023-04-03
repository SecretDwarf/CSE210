using System;

class Program
{
    static void Main(string[] args)
    {   
        string chosen = "";
        while(true)
        {
        Console.WriteLine("Please select one of the following choices: ");
        Console.Write(" 1. Breathing Activity \n 2. Reflection Activity \n 3. Listing Activity \n 4. Exit \n>");
        chosen = Console.ReadLine();
        // Console.WriteLine(chosen);
        Activity activity = null;
        switch(chosen)
        {
            case "1":
                activity =  new ActivityBreathing("Breathing Activity", "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                break;
            case "2":
                activity =  new ActivityReflection("Reflection Activity", "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                break;
            case "3":
                activity =  new ActivityListing("Listing Activity", "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                break;
            case "4":
                System.Environment.Exit(0);
                break;
        }
            activity.DoActivity();
        }
    }

}
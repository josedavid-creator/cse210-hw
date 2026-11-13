using System;

// Exceeding Requirements: The HideRandomWords method in the Scripture class was 
// designed to only select from words that are not already hidden.
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding";
        
        Scripture scripture = new Scripture(reference, text);
        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}
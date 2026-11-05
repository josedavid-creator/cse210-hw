using System;

/*
 * EXCEEDING REQUIREMENTS:
 * 1. Added a 'Mood' tracking feature to each journal entry. The user is prompted
 *    to record their current mood/emotion, which is displayed and saved/loaded to/from the file.
 * 2. Handled file not found exceptions gracefully with an informative message.
 */

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool isRunning = true;
        Console.WriteLine("Welcome to the Journal Program!");

        while (isRunning)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("What is your current mood/emotion? ");
                string mood = Console.ReadLine();

                DateTime now = DateTime.Now;
                string dateText = now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                theJournal.AddEntry(newEntry);
                Console.WriteLine("Entry recorded.\n");
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                isRunning = false;
                Console.WriteLine("Thank you for writing today. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose a number from 1 to 5.\n");
            }
        }
    }
}
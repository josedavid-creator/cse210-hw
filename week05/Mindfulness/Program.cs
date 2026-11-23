using System;

/*
 * Exceeding Requirements / Creativity:
 * 1. Session Activity Log: The program keeps track of how many times each activity
 *    (Breathing, Reflecting, and Listing) is completed during the current session,
 *    displaying a live count in the menu and a final summary when the user quits.
 * 2. Non-Repeating Questions: In ReflectingActivity, random questions are tracked
 *    in a separate list so that no question is repeated until all questions in the
 *    list have been used at least once.
 */

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        ReflectingActivity reflectingActivity = new ReflectingActivity();

        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine($"  1. Start breathing activity  (Completed: {breathingCount})");
            Console.WriteLine($"  2. Start reflecting activity (Completed: {reflectingCount})");
            Console.WriteLine($"  3. Start listing activity    (Completed: {listingCount})");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                reflectingActivity.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Session Summary:");
                Console.WriteLine($"- Breathing Activities completed: {breathingCount}");
                Console.WriteLine($"- Reflecting Activities completed: {reflectingCount}");
                Console.WriteLine($"- Listing Activities completed: {listingCount}");
                Console.WriteLine($"\nTotal activities completed: {breathingCount + reflectingCount + listingCount}");
                Console.WriteLine("Thank you for taking time to be mindful today. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number from 1 to 4.");
                System.Threading.Thread.Sleep(1500);
            }
        }
    }
}
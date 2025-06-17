using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            Console.Clear(); 

            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DispplayStartingMessage();
                    Console.Write("How long, in seconds, would you like to do this activity? ");
                    string durationInput = Console.ReadLine();
                    int duration = int.Parse(durationInput);
                    BreathingActivity breathingActivityTime= new BreathingActivity(duration);
                    breathingActivityTime.Run();
                    breathingActivityTime.DisplayEndingMessage();

                    break;
                case "2":
                    ReflectingActivity reflectionActivity = new ReflectingActivity();
                    reflectionActivity.DispplayStartingMessage();
                    Console.Write("How long, in seconds, would you like to do this activity? ");
                    string durationInput2 = Console.ReadLine();
                    int duration2 = int.Parse(durationInput2);
                    ReflectingActivity reflectingActivityTime = new ReflectingActivity(duration2);
                    reflectingActivityTime.Run();
                    reflectingActivityTime.DisplayEndingMessage();
                    
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DispplayStartingMessage();
                    Console.Write("How long, in seconds, would you like to do this activity? ");
                    string durationInput3 = Console.ReadLine();
                    int duration3 = int.Parse(durationInput3);
                    ListingActivity listingActivity1 = new ListingActivity(duration3);
                    listingActivity1.Run();
                    listingActivity1.DisplayEndingMessage();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return; 
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine(); 
        }
    }

}

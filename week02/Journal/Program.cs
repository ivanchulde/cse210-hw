using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    entry._promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(entry._promptText);
                    entry._entryText = Console.ReadLine();
                    journal._entries.Add(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "4":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        }


        
    }
}
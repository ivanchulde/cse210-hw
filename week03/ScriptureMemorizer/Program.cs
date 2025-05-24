using System;

class Program
{

    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScriptures("scriptures.txt");

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found in the file.");
            return;
        }

        bool keepGoing = true;
        Random random = new Random();

        while (keepGoing)
        {
            Scripture scripture = scriptures[random.Next(scriptures.Count)];
            Reference reference = scripture.GetReference();

            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());

            while (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Press Enter to continue, or type 'quit' to finish: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    return;

                scripture.HideRandomWords(3);

                Console.Clear();
                Console.WriteLine(reference.GetDisplayText());
                Console.WriteLine(scripture.GetDisplayText());
            }

            Console.WriteLine("Congratulations! You have memorized the scripture.");
            Console.WriteLine("Press Enter to load a new scripture, or type 'quit' to finish: ");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "quit")
            {
                keepGoing = false;
            }
        }

        Console.WriteLine("Thank you for using the Scripture Memorizer!");
    }
    
      static List<Scripture> LoadScriptures(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        foreach (string line in File.ReadAllLines(filePath))
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split('|');
            if (parts.Length < 4) continue;

            string book = parts[0];
            int chapter = int.Parse(parts[1]);

            string[] verseParts = parts[2].Split('-');
            int verse = int.Parse(verseParts[0]);
            int endVerse = (verseParts.Length > 1) ? int.Parse(verseParts[1]) : verse;

            Reference reference = new Reference(book, chapter, verse, endVerse);
            string text = parts[3];

            scriptures.Add(new Scripture(reference, text));
        }

        return scriptures;
    }
}
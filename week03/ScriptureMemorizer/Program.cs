using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
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

        // Cuando ya está completamente oculto
        Console.WriteLine("Press Enter to continue, or type 'quit' to finish: ");
        Console.ReadLine(); // Esperar antes de terminar
        
    }
}
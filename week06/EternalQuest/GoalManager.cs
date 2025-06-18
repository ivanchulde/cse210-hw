public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    

    public void Start()
    {
        bool running = true;
        while (running)
        {
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create a New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();



            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Create a New Goal");
                    

                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("List of Goals");
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Save Goals");
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Load Goals");
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("Record Events");
                    break;

                case "6":
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

    public void DisplayPlayerInfo()
    {
        Console.Clear();
        Console.WriteLine($"Your have {_score} points");
        Console.WriteLine("");
    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }
    
    public void LoadGoals()
    {
        
    }
}
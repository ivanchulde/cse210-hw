using System;
using System.Collections.Generic;
using System.IO;
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
            Console.Clear();
            Console.WriteLine($"\nYou have {_score} points.\n"); 
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
                    CreateGoal();

                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("List of Goals");
                    Console.WriteLine("Displaying all entries:");
                    ListGoalNames();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Save Goals");
                    SaveGoals();
                    Console.WriteLine("Goals saved successfully!");
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Load Goals");
                    LoadGoals();
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("Record Events");
                    RecordEvent();
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
        Console.Clear();
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Cheklist Goal");
        Console.WriteLine("Which type of goal would like to create? ");
        string goal = Console.ReadLine();

        switch (goal)
        {
            case "1":
                Console.WriteLine("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is short description of it?");
                string description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?");
                string inputpoints = Console.ReadLine();
                int points = int.Parse(inputpoints);
                _goals.Add(new SimpleGoal(name, description, points));
                Console.WriteLine("Simple Goal created successfully!");
                break;

            case "2":
                Console.WriteLine("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.WriteLine("What is short description of it?");
                description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?");
                inputpoints = Console.ReadLine();
                points = int.Parse(inputpoints);
                _goals.Add(new EternalGoal(name, description, points));
                Console.WriteLine("Eternal Goal created successfully!");
                break;

            case "3":
                Console.WriteLine("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.WriteLine("What is short description of it?");
                description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?");
                inputpoints = Console.ReadLine();
                points = int.Parse(inputpoints);
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                string inputtarget = Console.ReadLine();
                int target = int.Parse(inputtarget);
                Console.WriteLine("What is the bonus for accomplishing it that many times?");
                string inputbonus = Console.ReadLine();
                int bonus = int.Parse(inputbonus);
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                Console.WriteLine("CheckList Goal created successfully!");
                break;
        }

    }

    public void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Select the goal you accomplished:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the number of the goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            Console.WriteLine($"You have earned {points} points!");
            Console.WriteLine($"Your total score is now: {_score} points.");  // <--- Aquí
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }


    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string file = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string file = Console.ReadLine();

        if (File.Exists(file))
        {
            _goals.Clear();

            string[] lines = File.ReadAllLines(file);
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                switch (type)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                     int.Parse(parts[4]), int.Parse(parts[5])));
                        break;
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
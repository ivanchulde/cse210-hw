public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding you through breathing exercises.";
    }
    public BreathingActivity(int duration) : base(duration)
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding you through breathing exercises.";
        _duration = duration;
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready to begin the Breathing Activity.");
        ShowSpinner(5);
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(4);
            elapsed += 4;

            if (elapsed >= _duration) break;

            Console.Write("\nNow breathe out...");
            ShowCountdown(6);
            elapsed += 6;
            Console.WriteLine();
        }
        Console.WriteLine("\nWell done!");
        ShowSpinner(5);

        
    }
}
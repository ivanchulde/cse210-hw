public class CheklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {

    }
    
    public override void RecordEvent()
    {

    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}
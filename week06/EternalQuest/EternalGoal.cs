public class EtermalGoal : Goal
{
    public EtermalGoal(string name, string description, int points) : base(name, description, points)
    {

    }
    
    public override void RecordEvent()
    {

    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}
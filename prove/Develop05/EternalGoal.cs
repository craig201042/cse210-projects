public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {

    }
    public override int GetPoint()
    {
        return _points;
    }
    public override string Getname()
    {
        return _ShortName;
    }
    public override string GetCheckbox()
    {
        return _checkbox;
    }
    public override void SetCheckbox(string checkbox)
    {
        _checkbox=checkbox;
    }
    public override void RecordEvent() {
        Console.WriteLine($"Congratulations!You have earned {_points} points!");
    }
    
    public override bool IsComplete() {
           return false;
    }
    public override string GetStringRepresentation() {
         return $"EternalGoal:{_ShortName} ,{_description}, {_points}";
    }
}
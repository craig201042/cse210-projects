
using System.Reflection.Metadata.Ecma335;

public class SimpleGoal : Goal
{
    protected bool _isCompleted=false;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isCompleted = false;
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
        _isCompleted=true;
    }

    public override bool IsComplete() {
        return _isCompleted;
    }
    public override string GetStringRepresentation(){
        return $"SimpleGoal:{_ShortName} ,{_description}, {_points}, {_isCompleted}";
    }
        
}
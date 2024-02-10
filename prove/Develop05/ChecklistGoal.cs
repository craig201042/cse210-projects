public class ChecklistGoal : Goal
{
    private int _amountCompleted=0;
    private int _target;
    private int _bonus;

    private bool _isCompleted=false;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
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
        _amountCompleted+=1;
        if(_amountCompleted==_target){
            _points=_points+_bonus;
            Console.WriteLine($"Congratulations!You have earned {_points} points!");
            _isCompleted=true;
        }
        else{
            Console.WriteLine($"Congratulations!You have earned {_points} points!");
            _isCompleted=false;
        }
    }
      
    public override bool IsComplete() {
        return _isCompleted;
    }
    public override string GetDetailsString() {
        return $"{_checkbox} {_ShortName} ({_description})--Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation() {
        return $"ChecklistGoal:{_ShortName} ,{_description}, {_points}, {_bonus}, {_target}, {_amountCompleted}";
    }

}
public class Running:Activity{
    

    public Running(string date, int minutes, double distance):base(date, minutes, distance){
    
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes})-Distance{GetDistance()}km,speed{GetSpeed()},Pace{Math.Round(GetPace(),2)} min per km";
    }
}
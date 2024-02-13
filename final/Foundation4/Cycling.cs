public class Cycling:Activity{
    public Cycling(string date, int minutes, double distance):base(date, minutes, distance){
    
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_minutes})-Distance{GetDistance()}km,speed{GetSpeed()},Pace{Math.Round(GetPace(),2)} min per km";
    }
}
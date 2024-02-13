public class Swimming:Activity{
    private int _laps;

    public Swimming(string date, int minutes, double distance, int laps):base(date, minutes, distance){
        _laps=laps;
    }
  
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes})-Distance{GetDistance()}km,speed{GetSpeed()},Pace{Math.Round(GetPace(),2)} min per km,laps:{_laps}";
    }

}
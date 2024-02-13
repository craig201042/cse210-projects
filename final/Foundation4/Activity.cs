public class Activity{
    protected string _date;
    protected int _minutes;
    protected double _distance;
    
    public Activity(string date, int minutes, double distance){
               _date=date;
               _minutes=minutes;
               _distance=distance;
    }
    public virtual void SetDistance(double distance){
        _distance=distance;
    }
    public virtual double GetDistance(){
        return _distance;
    }
    public virtual double GetSpeed(){
        return (_distance/_minutes)*60;
    }
    public virtual double GetPace(){
        return _minutes/_distance;
    }
    public virtual string GetSummary(){
        return $"{_date}({_minutes})-Distance{_distance}km,speed{GetSpeed()},Pace{GetPace()} min per km";
    }

}
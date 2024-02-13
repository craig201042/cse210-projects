public class Outdoors:Event{
   private string _weather;

   public Outdoors(string title, string type, string description, string date, string time, Address address, string weather):base(title, type, description, date, time, address){
        _weather=weather;                  
   }
   public void fullDetails(){
     Console.WriteLine($"{_title}/{_type}({_description})--{_date}--{_time}\n{_address.GetAddress()}");
     Console.WriteLine($"Weather:{_weather}");
   }
}
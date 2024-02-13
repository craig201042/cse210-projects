public class Receptions:Event{
   private string _email;

   public Receptions(string title, string type, string description, string date, string time, Address address, string email):base(title, type, description, date, time, address){
        _email=email;                  
   }
   public void fullDetails(){
     Console.WriteLine($"{_title}/{_type}({_description})--{_date}--{_time}\n{_address.GetAddress()}");
     Console.WriteLine($"Emails:{_email}");
   }
}
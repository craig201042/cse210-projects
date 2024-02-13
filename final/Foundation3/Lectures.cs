public class Lectures:Event{
   private string _name;
   private string _capacity;
  

   public Lectures(string title, string type, string description, string date, string time, Address address, string name, string capacity):base(title, type, description, date, time, address){
        _name=name;
        _capacity=capacity;                  
   }
   public void fullDetails(){
     Console.WriteLine($"{_title}/{_type}({_description})--{_date}--{_time}\n{_address.GetAddress()}");
     Console.WriteLine($"{_name} Capacity:{_capacity}");
   }
   

}
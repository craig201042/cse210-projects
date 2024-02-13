using System.Net.Sockets;

public class Event{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address; 
    protected string _type;
    public Event(string title, string type, string description, string date, string time, Address address){
              _title=title;
              _description=description;
              _date=date;
              _time=time;
              _address=address;
              _type=type;
    }
    public void standardDetails(){
        Console.WriteLine($"{_title}/{_description}--{_date}--{_time}\n{_address.GetAddress()}");
    }
    public void shortDescription(){
    Console.WriteLine($"{_type},{_title}--{_date}--");
   }
    

}
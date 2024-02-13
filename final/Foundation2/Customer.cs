public class Customer{
    private string _name;
    private Address _address;
    private bool _liveInUsa;
    public Customer(string name, Address address){
        _name=name;
        _address=address;

    }
    public bool liveInUsa(){
        if(_address.isInUsa()==true){
             _liveInUsa=true;
        }
        else{
            _liveInUsa=false;
        }
        return _liveInUsa;
    }
    public void DisplayCustomerInfo(){
        Console.WriteLine($"{_name}---{_address.GetAddress()}");
    }
}
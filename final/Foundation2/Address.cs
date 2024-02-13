public class Address{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _isInUsa;
    public Address(string streetAddress, string city, string state, string country){
        _streetAddress=streetAddress;
        _city=city;
        _state=state;
        _country=country;
    }
    public bool isInUsa(){
          if(_country=="USA"){
               _isInUsa=true;
          }
          else{
            _isInUsa=false;
          }
          return _isInUsa;
    }
    public string GetAddress(){
        return $"{_streetAddress},{_city}\n{_state},{_country}";
    }
}
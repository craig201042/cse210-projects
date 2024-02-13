public class Order{
    private double sum;
    private List<Product> _products=new List<Product>();
    private List<Customer> _customers=new List<Customer>();
    private double totalprice;
    public Order(List<Product> products, List<Customer> customers){
            _products=products;
            _customers=customers;
    }
    public void AddProduct(Product p){
        _products.Add(p);
    }
    public void AddCustomer(Customer c){
        _customers.Add(c);
    }

    public double totalPrice(){
      foreach(Customer c in _customers){
       if(c.liveInUsa()==true){  
        foreach(Product p in _products){
            double cost=p.totalCost();
            sum+=cost;
        }
        totalprice=sum+5;
       }
       else{
        foreach(Product p in _products){
            double cost=p.totalCost();
            sum+=cost;
        }
        totalprice=sum+35;
       }
      }
      return totalprice;
    }
    public void packingLabel(){
        foreach(Product p in _products){
            p.DisplayProductInfo();
        }
    }
    public void shippingLabel(){
        foreach(Customer c in _customers){
            c.DisplayCustomerInfo();
        }
    }


}
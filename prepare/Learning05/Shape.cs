public class Shape{
    private string _color;
    private float _area;

    public Shape(string color){
        _color=color;
    }
   
    public string GetColor(){
        return _color;
    }

    public void SetColor(string color){
           _color=color;
    }
    public virtual float GetArea(){
        return _area;
    }

}
public class Rectangle:Shape{
    private float _length;
    private float _wide;

    public Rectangle(string color, float length, float wide):base(color){
        _length=length;
        _wide=wide;
    }
    public override float GetArea()
    {
        return _length*_wide;
    }
}
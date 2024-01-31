public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text){
         _text=text;
    }

    public string GetText(){
        return _text;
    }

    public void SetText(string text){
        _text=text;
    }
    public void Hide(){
        _text="_";
        Console.WriteLine(_text);
    }
    public void Show(){
        Console.WriteLine(_text);
    }
    public bool IsHidden(){
        if(_text=="_"){
           _isHidden=true;
        }
        else{
           _isHidden=false;
        }
        return _isHidden;
    }
}
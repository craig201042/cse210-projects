public class MathAssignment:Assignment{

    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string tbs, string problems):base(name, topic){
             
                  _textbookSection=tbs;
                  _problems=problems;      
    }   

    public string GetHomeworkList(){
          
             return _textbookSection+" "+_problems;
    }  

}

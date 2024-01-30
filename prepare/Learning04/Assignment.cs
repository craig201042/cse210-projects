public class Assignment{
    private string _studentName;
    
    private string _topic;

    public string GetStudentName(){
      return _studentName;
    }

    public void SetStudentName(string studentName){
      _studentName=studentName;
    }
     public string GetTopic(){
      return _studentName;
    }

    public void SetTopic(string topic){
      _topic=topic;
    }
   
    public Assignment(string name, string topic){
     
          _studentName=name;
          _topic=topic;
            
    }
    public string GetSummary(){
          return _studentName+"-"+_topic;
    } 

}
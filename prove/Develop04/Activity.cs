public class Activity{
    private string _name;
    private string _description;

    private int _duration;

    public Activity(string name, string description){
        _name=name;
        _description=description;
    }
    public int GetDuration(){
        return _duration;
    }

    public void SetDuration(int duration){
        _duration=duration;
    }

    public void DisplayStartingMessage(){
          Console.WriteLine($"Welcome to the {_name} activity.");
          Console.WriteLine($"{_description}");

    }

    public void DisplayEndingMessage(){
             Console.WriteLine("Well done!");
             ShowSpinner(5);

             Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity");
             ShowSpinner(5);
    }
    public void ShowSpinner(int second){
          List<string> animaString=new List<string>();
          animaString.Add("|");
          animaString.Add("\\");
          animaString.Add("—");
          animaString.Add("/");
          animaString.Add("—");
          animaString.Add("\\");
          animaString.Add("|");
          DateTime startTime=DateTime.Now;
          DateTime futureTime=startTime.AddSeconds(second);
        
          int i=0;
          while(DateTime.Now<futureTime){
            string s=animaString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if(i>=animaString.Count){
                i=0;
            }
          }

    }
    public void ShowCoundown(int second){
        for(int i=second;i>0;i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");   
        } 


    }
}
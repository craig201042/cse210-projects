public class BreathingActivity:Activity{
    
    public BreathingActivity(string name, string description):base(name, description){
        
    }   
    public void run(){
        DisplayStartingMessage();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string response=Console.ReadLine();
        int answer=int.Parse(response);
        SetDuration(answer);
        Console.Clear();
        Console.WriteLine("Get ready.....");
        ShowSpinner(3);

        DateTime startTime=DateTime.Now;
        DateTime futureTime=startTime.AddSeconds(GetDuration());
        while(DateTime.Now<futureTime){
         Console.Write("Breath in....");
         ShowCoundown(3);
         Console.WriteLine("\r");
         Console.Write("Now Breath out.....");
         ShowCoundown(5);
         Console.WriteLine();
        }
        DisplayEndingMessage();

    }
}
public class ListingActivity:Activity{
    private int _count;
    private List<string> _prompts;

    private List<string> _responses=new List<string>();
    private string p;

    public ListingActivity(string name, string description, List<string> prompts):base(name, description){
                 prompts.Add("Who are people that you appreciate?");
                 prompts.Add("What are personal strengths of yours?");
                 prompts.Add("Who are people that you have helped this week?");
                 prompts.Add("When have you felt the Holy Ghost this month?");
                 prompts.Add("Who are some of your personal heroes?");
                 _prompts=prompts;
    }
    public void run(){
        DisplayStartingMessage();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string response=Console.ReadLine();
        int answer=int.Parse(response);
        SetDuration(answer);  

        Console.WriteLine("Get ready.....");
        ShowSpinner(3);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"----{GetRandomPrompt()}-------");

        Console.Write($"You may begin in:");
        ShowCoundown(5);
        Console.WriteLine();
        
        DateTime startTime=DateTime.Now;
        DateTime futureTime=startTime.AddSeconds(GetDuration());
        while(DateTime.Now<futureTime){
             GetListFromUser();
        }    
        _count=_responses.Count;
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
         Random rnd=new Random();
         p=_prompts[rnd.Next(_prompts.Count)];
         return p;
    }
    public List<string> GetListFromUser(){
         string userInput=Console.ReadLine();
         _responses.Add(userInput);
         return _responses;
    }
    

}
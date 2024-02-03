public class ReflectingActivity:Activity{
    
    protected List<string> _prompts;
    protected List<string> _questions;
    private string p;
    private string q;

    Random rnd=new Random();
    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions):base(name, description){
       prompts.Add("Think of a time when you stood up for someone else.");
       prompts.Add("Think of a time when you did something really difficult.");
       prompts.Add("Think of a time when you helped someone in need.");
       prompts.Add("Think of a time when you did something truly selfless.");
       _prompts=prompts;

       questions.Add("Why was this experience meaningful to you?");
       questions.Add("Have you ever done anything like this before?");
       questions.Add("How did you get started?");
       questions.Add("How did you feel when it was complete?");
       questions.Add("What made this time different than other times when you were not as successful?");
       questions.Add("What is your favorite thing about this experience?");
       questions.Add("What could you learn from this experience that applies to other situations?");
       questions.Add("What did you learn about yourself through this experience?");
       questions.Add("How can you keep this experience in mind in the future?");
       _questions=questions;
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
        Console.WriteLine("Consider the following prompt:");
        GetRandomPrompt();
        DisplayPrompt();

        Console.WriteLine("When yo have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they related to this experience.");
        Console.Write($"You may begin in:");
        ShowCoundown(5);
        
        Console.Clear();
        DateTime startTime=DateTime.Now;
        DateTime futureTime=startTime.AddSeconds(GetDuration());
        while(DateTime.Now<futureTime){
          GetRandomQuestion();
          DisplayQuestion();
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt(){
         p=_prompts[rnd.Next(_prompts.Count)];
         return p;
    }
    public string GetRandomQuestion(){
         string q=_questions[rnd.Next(_questions.Count)];
         return q;
    }
    public void DisplayPrompt(){
          Console.WriteLine($"----- {p} -----"); 
    }

    public void DisplayQuestion(){
          Console.WriteLine(q);
          ShowSpinner(5);
    }
}
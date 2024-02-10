using System.IO;
using System.Security.Cryptography.X509Certificates;
public class GoalManager
{
    private List<Goal> _goalList = new List<Goal>();
    
    private List<string> _goalType= new List<string>();

    private int _score;

    private string datatype;

    private Goal g;

    private int option=0;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start() { 
      while(option!=6){ 
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        List<string> _option= new List<string>();
        _option.Add("1.Create New Goal");
        _option.Add("2.List Goals");
        _option.Add("3.Save Goals");
        _option.Add("4.Load Goals");
        _option.Add("5.Record Event");
        _option.Add("6.Quit");
        foreach(string s in _option){
            Console.WriteLine(s);
        }
        Console.WriteLine("Select a choice from menu:");
        option=int.Parse(Console.ReadLine());
        if(option==1){
            CreateGoal();
         }
         else if(option==2){
            ListGoalDetails();
         }
         else if(option==3){
            SaveToFile();
         }
         else if(option==4){
            LoadFromFile();
         }
         else if(option==5){
            RecordEvent();
         }
         else if(option==6){
            break;
         }
      }
    }
    public void DisplayPlayerInfo() {
        Console.WriteLine($"You now have {_score} points.");
        Console.WriteLine();
    }
    public void ListGoalNames() {
        for(int i=0;i<_goalList.Count;i++){
            Console.WriteLine($"{i+1}.{_goalList[i].Getname()}");
        }
    }
    public void ListGoalDetails() {
        Console.WriteLine("The goals are:");
        for(int i=0;i<_goalList.Count;i++){
            if(_goalList[i].IsComplete()==true){
                _goalList[i].SetCheckbox("[x]");
                _goalList[i].GetCheckbox();
                Console.WriteLine($"{i+1}.{_goalList[i].GetDetailsString()}");
            }
            else{
                _goalList[i].SetCheckbox("[]");
                _goalList[i].GetCheckbox();
                Console.WriteLine($"{i+1}.{_goalList[i].GetDetailsString()}");
            }
        }
    }
    public void CreateGoal() {
        _goalType.Add("1.Simple Goal");
        _goalType.Add("2.Eternal Goal");
        _goalType.Add("3.CheckList Goal");
        Console.WriteLine("The types of Goals are:");
        foreach(string s in _goalType){
            Console.WriteLine(s);
        }
        Console.Write("Which type of goal would you like to create?");
        int type=int.Parse(Console.ReadLine());
        if(type==1){
           Console.Write("What is the name of your goal?");
           string shortName=Console.ReadLine();
           Console.Write("What is a short description of it?");
           string Description=Console.ReadLine();
           Console.Write("What is the amount of points associated with this goal?");
           int  Points=int.Parse(Console.ReadLine());
           g= new SimpleGoal(shortName, Description, Points);
        } 
        else if(type==2){
           Console.Write("What is the name of your goal?");
           string shortName=Console.ReadLine();
           Console.Write("What is a short description of it?");
           string Description=Console.ReadLine();
           Console.Write("What is the amount of points associated with this goal?");
           int  Points=int.Parse(Console.ReadLine());
           g= new EternalGoal(shortName, Description, Points);
        }
        else if (type==3){
           Console.Write("What is the name of your goal?");
           string shortName=Console.ReadLine();
           Console.Write("What is a short description of it?");
           string Description=Console.ReadLine();
           Console.Write("What is the amount of points associated with this goal?");
           int  Points=int.Parse(Console.ReadLine());
           Console.Write("How many times does this goal need to be accomplished for a bonus?");
           int Target=int.Parse(Console.ReadLine());
           Console.Write("What is the bonus for accomplishing it that many times?");
           int Bonus=int.Parse(Console.ReadLine());
           g= new ChecklistGoal(shortName, Description, Points, Target, Bonus);
        }
        _goalList.Add(g);
    }
    public void RecordEvent() {
        Console.WriteLine("The Goals are:");
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish?");
        int choice=int.Parse(Console.ReadLine());
        _goalList[choice-1].RecordEvent();
        _score+=_goalList[choice-1].GetPoint();
        DisplayPlayerInfo();
    }
    public void SaveToFile() {
      Console.WriteLine("What is the filename for the goal file?");
      string filename =Console.ReadLine();
      using (StreamWriter outputFile = new StreamWriter(filename))
      {
         outputFile.WriteLine(_score);
         foreach(Goal g in _goalList){
           outputFile.WriteLine(g.GetStringRepresentation());
         }
      }
    }
    public void LoadFromFile() {
        Console.WriteLine("What is the filename for the goal file?");
        string filename =Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        for(int i=1;i<lines.Length;i++)
        {
           string[] parts = lines[i].Split(":");

           datatype = parts[0];
           string stringDetail = parts[1];
           g=CreateGoals(stringDetail);
           _goalList.Add(g);
        }
    }
    public Goal CreateGoals(string detail){
        if(datatype=="SimpleGoal"){ 
          string[] parts= detail.Split(",");
          string shortName= parts[0];
          string description= parts[1];
          int points=int.Parse(parts[2]);
          string iscompleted= parts[3];
          g= new SimpleGoal(shortName, description, points);
        }  
        else if(datatype=="EternalGoal"){
          string[] parts= detail.Split(",");
          string shortName= parts[0];
          string description= parts[1];
          int points=int.Parse(parts[2]);
          g= new EternalGoal(shortName, description, points);
        }
        else if(datatype=="ChecklistGoal"){
          string[] parts= detail.Split(",");
          string shortName= parts[0];
          string description= parts[1];
          int points=int.Parse(parts[2]);
          int bonus= int.Parse(parts[3]);
          int target=int.Parse(parts[4]);
          int amountOfComplete=int.Parse(parts[5]); 
          g= new ChecklistGoal(shortName, description, points, target, bonus); 
        } 
        return g;
    }
}
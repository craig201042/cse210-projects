
public class PromptGenerator{
    public List<string> _prompts = new List<string>();
    public string _text;
    public string GetRandomPrompt(){
      	 _prompts.Add("Who was the most interesting person I interacted with today?");
         _prompts.Add("What was the best part of my day?");
         _prompts.Add("How did I see the hand of the Lord in my life today?");
         _prompts.Add("What was the strongest emotion I felt today?");
         _prompts.Add("If I had one thing I could do over today, what would it be?");
         _prompts.Add("What breakfast would I like to eat tomorrow?");

          
          Random rnd=new Random();
          int next=rnd.Next(_prompts.Count);
          if(next==0){
             _text=_prompts[next];
          }
          else if(next==1){
             _text=_prompts[next];
          }          
          else if(next==2){
             _text=_prompts[next];
          }
          else if(next==3){
             _text=_prompts[next];
          }
          else if(next==4) {
             _text=_prompts[next];
          }
          else if(next==5){
              _text=_prompts[next];
          }
          return _text;         
   }

}
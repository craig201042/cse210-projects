
public class Scripture{
    private Reference _reference;
    private List<Word> _words=new List<Word>(); 
    private Word w=new Word("text");
    private List<string> s;

    private bool _IsCompletelyHidden;

    public Scripture(Reference reference,string text){
             _reference=reference;
             s=text.Split(',').ToList();
             for(int i=0;i<s.Count;i++){
                 w.SetText(s[i]);
                _words.Add(w);
             }
    }
    public void HideRandomWords(int numberToHide){         
           if(numberToHide<_words.Count){
           _words[numberToHide].Show();
           Console.ReadLine();
           Console.Clear();
           _words[numberToHide].Hide();
          }
          else{
            return;
          }
    }
    public string GetTheDispaly(){ 
          foreach(Word w in _words){
                int i=0;
                if(i<_words.Count){
                  s[i]=w.GetText();
                  i++;
                }
          }
          string s1=string.Join(" ", s);
          return _reference.GetDispalyText()+s1;
    }
    public bool IsCompletelyHidden(){
          foreach(Word w in _words){
            if(w.IsHidden()==true){
                _IsCompletelyHidden=true;
            }
            else{
              _IsCompletelyHidden=false;
            }
          }      
          return _IsCompletelyHidden;                  
    }

}



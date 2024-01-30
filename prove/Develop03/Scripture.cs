
public class Scripture{
    private Reference _reference;
    private List<Word> _words=new List<Word>(); 
    private List<string> s;
    private Random rnd=new Random();

    private bool _IsCompletelyHidden;

    public Scripture(Reference reference,string text){
             _reference=reference;
             s=text.Split(',').ToList();
             for(int i=0;i<s.Count;i++){
                 Word w=new Word("text");
                 w.SetText(s[i]);
                _words.Add(w);
             }
    }
    public void HideRandomWords(int numberToHide){         
          for(int i=0;i<numberToHide;i++){
           int rndNumber=rnd.Next(_words.Count);
           _words[rndNumber].Show();
           Console.ReadLine();
           Console.Clear();
           _words[rndNumber].Hide();
           _words[rndNumber].SetText("_");
          }
    }
    public string GetTheDispaly(){ 
          for(int i=0;i<_words.Count;i++){
                  s[i]=_words[i].GetText();
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
              break;
            }
          }      
          return _IsCompletelyHidden;                  
    }

}




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
           Random rnd=new Random();         
           numberToHide=rnd.Next(_words.Count);
           _words[numberToHide].Show();
           Console.ReadLine();
           Console.Clear();
           _words[numberToHide].Hide();
    }
    public string GetTheDispaly(){ 
          for(int i=0;i<_words.Count;i++){
                s[i]=_words[i].GetText();
             }
          string s1=string.Join(" ", s.ToArray());
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



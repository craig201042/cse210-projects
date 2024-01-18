
public class Journal{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
           _entries.Add(entry);
    }
    public void Display(){
        foreach(Entry e in _entries){
            e.Display();
        }
    }
    public void saveFile(string filename){
        using(StreamWriter outputFile = new StreamWriter(filename)){
        
             foreach(Entry e in _entries){
                      
                outputFile.WriteLine(e);
             }
        }
    }
    public void loadFile(string filename){
               
         string[] journal_load=System.IO.File.ReadAllLines(filename);
         foreach(string j in journal_load){
            Console.WriteLine(j);
         }
    }

}
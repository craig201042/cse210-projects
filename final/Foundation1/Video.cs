using System.Transactions;

public class Video{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments= new List<Comment>();

    public Video(string title, string author, int length){
               _title=title;
               _author=author;
               _length=length; 
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }

    public void DisplayVideoInfo(){
             Console.WriteLine($"Title:{_title},Author:{_author}({_length})--{CommentNumber()}");
    } 

    public int CommentNumber(){
        return _comments.Count;
    }
}
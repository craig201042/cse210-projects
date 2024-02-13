using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos= new List<Video>();
        Video v1= new Video("Hungry eater","Alan",180);
        Video v2= new Video("Bike travel","John",270);
        Video v3= new Video("Amazing basketball","Mary",210);

        Comment c1= new Comment("Craig","Delicious food is tasty,but if too much,it just became overlooaded for bodies.");
        Comment c2= new Comment("Simmons","Sushi is one of my favorite kind.");
        Comment c3= new Comment("Peter","There's so many kinds of hamburger in states.I just don't know which one  I should choose to begin my food jouney.");
        Comment c4= new Comment("Rose","What a gracious scene in Iran!That's just beatiful");
        Comment c5= new Comment("Jacob","it's totally different taveling experience with by cars or airplanes.");
        Comment c6= new Comment("Frank","keep the safe equipments,have a pleasant travel.");
        Comment c7= new Comment("James","I love Lebron's attitude with games.It's one of qualities of his success.");
        Comment c8= new Comment("Clay","it's just extraoridanary for Curry's 3PT%.");
        Comment c9= new Comment("Mark","it's more and more international for NBA League.");

        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);
        v2.AddComment(c4);
        v2.AddComment(c5);
        v2.AddComment(c6);
        v3.AddComment(c7);
        v3.AddComment(c8);
        v3.AddComment(c9);
        
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        
        foreach(Video v in videos){
           v.DisplayVideoInfo();
          foreach(Comment c in v._comments){
            c.DisplayCommentInfo();
          }
        }


    }
}
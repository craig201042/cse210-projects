using System;
using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
       Square sq=new Square("brown", 4);
       Console.WriteLine(sq.GetColor());
       Console.WriteLine(sq.GetArea());

       Rectangle rec=new Rectangle("black", 4, 3);
       Circle cir=new Circle("red", 3);

       List<Shape> shapes=new List<Shape>();
       shapes.Add(sq);
       shapes.Add(rec);
       shapes.Add(cir);

       foreach(Shape s in shapes){
         Console.WriteLine(s.GetColor());
         Console.WriteLine(s.GetArea());
       }
    }
}
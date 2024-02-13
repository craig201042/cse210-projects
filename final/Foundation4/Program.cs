using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities=new List<Activity>();
        DateTime d1=new DateTime(2024, 11, 3);
        DateTime d2=new DateTime(2024, 10, 3);
        DateTime d3=new DateTime(2024, 9, 3);
        string date01=d1.ToString("dd/MM/yyyy");
        string date02=d2.ToString("dd/MM/yyyy");
        string date03=d3.ToString("dd/MM/yyyy");
        Running run=new Running(date01, 60, 4.2);
        Cycling bike=new Cycling(date02, 60, 8.6);
        Swimming swim=new Swimming(date03, 60, 5.6, 10);

        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        foreach(Activity a in activities){
              Console.WriteLine(a.GetSummary());
        }
       

    }
}
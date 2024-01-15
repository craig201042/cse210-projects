using System;

class Program
{
    
    static void Main(string[] args)
    {
        Job job1=new Job();
        Job job2=new Job();
        job1._jobTitle="Social worker";
        job1._company="Charity foundation";
        job1._startYear=2010;
        job1._endYear=2011;

        job2._jobTitle="QC Engineer";
        job2._company="Sinbon";
        job2._startYear=2011;
        job2._endYear=2013;

        Resume myResume=new Resume();
        myResume._name="Craig Zeng";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}
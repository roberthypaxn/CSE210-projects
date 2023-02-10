using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
    // Job instances
    Job job1 = new Job("Internet Computer", "C.E.O", 1700, 1800);
    Job job2 = new Job("LinkedIn", "C.E.O", 1800, 1900);
    Job job3 = new Job();
    Job job4 = new Job();
    
    job3._company = "Microsoft";
    job3._jobTitle = "C.E.O";
    job3._startYear = 1900;
    job3._endYear = 2000;

    
    job4._company = "Apple";
    job4._jobTitle = "C.E.O";
    job4._startYear = 2000;
    job4._endYear = 2023;

    // Resume instance
    Resume myResume = new Resume();
    myResume._nameOfPerson = "Man on Earth";

    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);
    myResume._jobs.Add(job3);
    myResume._jobs.Add(job4);
    myResume.Display();
    }
}
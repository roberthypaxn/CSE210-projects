using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
    // Job instances
    Job job1 = new Job();
    job1._company = "Microsoft";
    job1._jobTitle = "C.E.O";
    job1._startYear = 1900;
    job1._endYear = 2000;

    Job job2 = new Job();
    job2._company = "Apple";
    job2._jobTitle = "C.E.O";
    job2._startYear = 2000;
    job2._endYear = 2023;

    Console.WriteLine("-------------------------------------");
    job1.Display();
    Console.WriteLine("-------------------------------------");
    job1.DisplayJobDetails();
    Console.WriteLine("-------------------------------------");
    job2.DisplayJobDetails();
    Console.WriteLine("-------------------------------------");
    }
}
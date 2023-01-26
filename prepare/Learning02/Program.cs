using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
    // Job instance
    Job job1 = new Job();
    job1._company = "Microsoft";
    job1._jobTitle = "C.E.O";
    job1._startYear = 1900;
    job1._endYear = 2000;

    Console.WriteLine("-------------------------------------");
    job1.Display();
    }
}
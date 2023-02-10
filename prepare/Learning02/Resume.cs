using System;

//Job Class

public class Resume
{
    //member varialbles
    public string _nameOfPerson = "";
    public List<Job> _jobs = new List<Job>();
    //method
    public void Display()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"Name: {_nameOfPerson}");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
        Console.WriteLine("-------------------------------------");

    }
}

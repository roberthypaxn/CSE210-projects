using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.Write("What is you first name? ");
        string fname = Console.ReadLine();
        Console.Write("What is you last name? ");
        string lname = Console.ReadLine();
        Console.WriteLine("Your name is " + lname + ", " + fname + " " + lname);
    }
}
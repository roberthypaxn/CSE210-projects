using System;

class Program
{
    static void Main(string[] args)
    {
        //Welcome message
        Console.WriteLine("---------------------------");
        Console.WriteLine("Welcome to Your journal");
        Console.WriteLine("----------------------------------------------");
        //Menu
        int newNumber = 0;
        while (newNumber != 5)
        {
            //Asking user for input
            List<int> numbers = new List<int>();
            Console.WriteLine("Please select one of the following options:");
            
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("----------------------------------------------");
            Console.Write("What would you like to do? ");
            string newNum = Console.ReadLine();
            newNumber = int.Parse(newNum);

        }

    }
}
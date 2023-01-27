using System;

class Program
{
    static void Main(string[] args)
    {
        //Welcome message
        Console.WriteLine("---------------------------");
        Console.WriteLine("Welcome to Your journal");
        Console.WriteLine("----------------------------------------------");

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
        int newNumber = int.Parse(newNum);

        //put the above in a loop that adds to the list until someone hits zero
       while (newNumber != 5)
       {
            Console.WriteLine("Wazzaaa!");
            string chosenNumber = Console.ReadLine();
            Console.WriteLine(chosenNumber);
            newNumber = int.Parse(chosenNumber);
       }

    }
}
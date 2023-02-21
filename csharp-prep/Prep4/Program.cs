using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Asking user for input
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string newNum = Console.ReadLine();
        int newNumber = int.Parse(newNum);
        int summation = 0;
        int maximum = 0;
        //put the above in a loop that adds to the list until someone hits zero
       while (newNumber != 0)
       {
            numbers.Add(newNumber);
            Console.Write("Enter number: ");
            newNum = Console.ReadLine();
            newNumber = int.Parse(newNum);
       }
       //summation
        for (int i = 0; i < numbers.Count; i++)
        {
            summation = summation + numbers[i];
            //maximum number
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];

            }

        }
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"The Largest number is: {maximum}");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"The sum of these numbers is: {summation}");
        Console.WriteLine("-------------------------------------");
        //average
        float average = ((float)summation) / numbers.Count;
        Console.WriteLine($"The average of these numbers is: {average}");
        Console.WriteLine("-------------------------------------");

    }
}
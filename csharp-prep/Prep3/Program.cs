using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicNum = Console.ReadLine();
        int magicNumber = int.Parse(magicNum);
        
        Console.Write("What is your guess? ");
        string guessText = Console.ReadLine();
        int guess = int.Parse(guessText);

        //if (guess < magicNumber)
        //{
        //    Console.WriteLine("Higher");
        //}
        //else if (guess > magicNumber)
        //{
        //    Console.WriteLine("Lower");
        //}
        
        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher ");
                string guessedNum = Console.ReadLine();
                guess = int.Parse(guessedNum);

            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
                string guessedNum = Console.ReadLine();
                guess = int.Parse(guessedNum);
            }
        }

        if (guess == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }
    }
}

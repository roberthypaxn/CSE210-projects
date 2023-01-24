using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        string magicNum = Console.ReadLine();
        int magicNumber = int.Parse(magicNum);
        Console.WriteLine("what is your guess? ");
        string guessText = Console.ReadLine();
        int guess = int.Parse(guessText);
    }
}
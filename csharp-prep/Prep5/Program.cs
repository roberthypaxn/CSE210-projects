using System;

class Program
{
    static void Main(string[] args)
    {
        //Function that displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        DisplayWelcome();

        //Function PromptUserName - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        //Function PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string favNum = Console.ReadLine();
            int favoriteNumber = int.Parse(favNum);
            return favoriteNumber;
        }
        
        //Function SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int given)
        {
           int squared = given * given;
           return squared;
        }
        
    }
}
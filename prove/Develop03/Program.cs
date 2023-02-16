using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.Erase();
        Console.WriteLine("");
        string firstTime = scripture.displayWhole();
        
        Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
        string doThisNext = Console.ReadLine();
        string hidden = scripture.Hidden(firstTime);
        while (doThisNext.ToUpper() != "QUIT")
        {
            scripture.Erase();
            Console.WriteLine(hidden);

            // check if all non-space, non-first two words are hidden
            bool allHidden = true;
            string[] hiddenWords = hidden.Split(' ');
            for (int i = 2; i < hiddenWords.Length; i++)
            {
                if (!hiddenWords[i].All(c => c == '-'))
                {
                    allHidden = false;
                    break;
                }
            }

            if (allHidden)
            {
                doThisNext = "QUIT";
            }
            else
            {
                hidden = scripture.Hidden(hidden);
                Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
                doThisNext = Console.ReadLine();
            }
        }


    }
}
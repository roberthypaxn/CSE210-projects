using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        //Welcome message
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("Welcome to Your journal");
        Console.WriteLine("------------------------------------------------------");
        //Instances
        Journal journaling = new Journal();
        PromptGenerator encouragement = new PromptGenerator();
        //Menu loop
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
            Console.WriteLine("------------------------------------------------------");
            Console.Write("What would you like to do? ");
            string newNum = Console.ReadLine();
            newNumber = int.Parse(newNum);
            //Switch to manage user's choices 
            switch (newNumber)
            {
                case 1:
                    // The following lines fetch the current date and current time and
                    //concatenate them in one string
                    Entry newEntry = new Entry();
                    string timer = DateTime.Now.ToLongTimeString();
                    string dater = DateTime.Now.ToShortDateString();
                    newEntry._currentTime = $"{dater} - {timer}";
                    //The following lines create a random number between zero and nine
                    Random randomness = new Random();
                    int randomNumber = randomness.Next(0,9);
                    //The random number is used as index in the ReturnPrompt Method from
                    //PromptGenerator calss, and a journaled entry is captured in _textEntries
                    newEntry._promptMessage = encouragement.ReturnPrompt(randomNumber);
                    Console.WriteLine($"\n{newEntry._promptMessage}\n");
                    Console.Write("> ");
                    newEntry._journaledText = Console.ReadLine();
                    Console.WriteLine();
                    journaling._textEntries.Add(newEntry);
                    break;
                //To display the text one has journaled
                case 2:
                    journaling.Display();
                    break;
                //Loading content from file, using delimite ~
                //For files where we might want to read the full content/paragraphs
                //so that lines are not broken before delimiters are reaches
                //we can use File.ReadAllContent(filename) instead of ReadAllLines(filename)
                case 3:
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("~");
                        Entry readJournal = new Entry();

                        readJournal._currentTime = parts[0];
                        readJournal._promptMessage = parts[1];
                        readJournal._journaledText = parts[2];

                        Console.WriteLine(readJournal._currentTime);
                        Console.WriteLine(readJournal._promptMessage);
                        Console.WriteLine(readJournal._journaledText);

                    }
                    break;
                //Writing new lines in our file
                case 4:
                    Console.WriteLine("What is the name of the file?");
                    string fileToRead = Console.ReadLine();
                    // To prevent the new entries from replacing the old ones in the file
                    //a boolean of true is added in the StreamWriter class instantiation
                    using (StreamWriter outputFile = new StreamWriter(fileToRead, true))
                    {
                        foreach (Entry writing in journaling._textEntries)
                        {
                            outputFile.WriteLine($"{writing._currentTime} ~ {writing._promptMessage} ~ {writing._journaledText}");
                        }
                    }
                    break;
                case 5:
                    newNumber = 5;
                    break;
                default:
                    //in case someone chooses something different from 1,2,3,4,5
                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine("| !!! Please choose a valid number from the menu !!! |");
                    Console.WriteLine("------------------------------------------------------");
                    break;
            }
        }

    }
}
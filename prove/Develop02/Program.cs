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
            Console.WriteLine("------------------------------------------------------");
            Console.Write("What would you like to do? ");
            string newNum = Console.ReadLine();
            newNumber = int.Parse(newNum);

            switch (newNumber)
            {
                case 1:
                    Entry newEntry = new Entry();
                    newEntry._currentTime = DateTime.Now.ToShortDateString();
                    Random randomness = new Random();
                    int randomNumber = randomness.Next(0,9);
                    newEntry._promptMessage = encouragement.ReturnPrompt(randomNumber);
                    Console.WriteLine($"\n{newEntry._promptMessage}\n");
                    Console.Write("> ");
                    newEntry._journaledText = Console.ReadLine();
                    Console.WriteLine();
                    journaling._textEntries.Add(newEntry);
                    break;
                case 2:
                    journaling.Display();
                    break;
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
                
                case 4:
                    Console.WriteLine("What is the name of the file?");
                    string fileToRead = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(fileToRead))
                    {
                        foreach (Entry writing in journaling._textEntries)
                        {
                            outputFile.WriteLine($"{writing._currentTime} ~ {writing._promptMessage} ~ {writing._journaledText}");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("______________________________________________________");
                    Console.WriteLine("| !!! Please choose a valid number from the menu !!! |");
                    Console.WriteLine("------------------------------------------------------");
                    break;
            }
        }

    }
}
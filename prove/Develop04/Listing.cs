using System;

class Listing : Activity
{
    private Random _random = new Random();
    private int indexe;
    private int counting;
    List<string> _phrase = new List<string>()
    {
        "How capable of goodness are you?",
        "What book can you recommend to a friend and why?",
        "What does nihilism looks like to you?",
        "What should you do to love yourself?",
        "What should anyone look for in relationships?"
    };
    public Listing(string chosenActivity, string describeActivity) : base(chosenActivity, describeActivity)
    {
        indexe = _random.Next(0, _phrase.Count);
    }
    public void ListActivity()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_phrase[indexe]} ---\n");
        //Count down in before beginning
        Console.Write("You may begin in: ");
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.Write("\b\b \b");
        }
        Console.WriteLine();

        int _session = GetChosenTime();
        DateTime startTime = DateTime.Now;
        DateTime ender = startTime.AddSeconds(_session);
        while (DateTime.Now < ender)
        {
            Console.Write("> ");
            Console.ReadLine();
            counting++;
        }
        Console.WriteLine($"You have listed {counting} items.");

        Console.WriteLine("\n");


    }
}
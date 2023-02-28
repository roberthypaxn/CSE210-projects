using System;

class Reflecting : Activity
{
    private Random randomPhrase = new Random();
    private int indx;
    private string _magicPhrase;
    private List<string> _magicQuestions;
    private Dictionary<string, List<string>> _promptPhrase = new Dictionary<string, List<string>>()
    {
        {"Think of a time you did something difficult that you did not know you could manage.",new List<string>() { "How did you feel after you had finished that task?", "Do you think there is a limit to the good things you are capable of doing?", "Do you think there is a limit to the bad things you are capable of doing?"} },
        {"Think of something that could would make your life and the lives of the people around you more healthy.", new List<string>() {"What is the easiest step anyone can manage to bring it into existence?", "What is the next easiest step that anyone can manage for the next step?", "Do you want to start now and keep going? If yes, what would be the consequences? If No, what would be the consequences?"}},
        {"Think of your closest friend.", new List<string>() {"Can you tell them good news when you have some good news?", "Can you tell them bad news when you have bad news?", "How do they react when something new strange arise between you two?"}},
        {"Think of what has changed about you during the past 2 years.", new List<string>() { "Has something changed at all?", "If nothing has changed, is there something that bothers you? If there is, do something about it.", "Do you like who you are becoming?", "If you like who you are becoming, what can you do to help others become what THEY WANT (not become exactly like you) too?", "If you do not like who you are becoming, what is the first and smallest step to become who you would love to be? Execute this step and think of the next small enough step that you can easily do, and keep going."} },
        {"Think of something that bothers you.", new List<string>() {"What is the simplest step you can do to begin changing what bothers you?", "Do it and think of the next simplest step to do and keep going" } },
        {"Reflect of this statement: Set your house in perfect order before you criticize the world.", new List<string>() { "Would you achieve such a virtue?", "If you would achieve it, how much strength would it take you? Would you judge the people who may not have that strength?", "If you would never achieve it, should you judge anyone?" } },
        {"Think of what would happen if you had no more problems in your life.", new List<string>() { "Would you like it if there was no more problems to solve and nothing more to achieve?", "Should human beings really aim to only be always happy?" }},
        {"Think of a good excuse for you to tell a small lie.", new List<string>() { "When you lie you have to act out the lie so that other people believe you, repeated actions create habits, what could go wrong if you had a habit that was not congruent with reality?", "Can the consequence of the small lie be much more dire than taking responsibility of hard truths?" } },
        {"Think of things other people know that you don't you know.", new List<string>() { "Are you always right in your thoughts and speech?", "Should you listen to others to find out what they know or should you always give them advices" } },
        {"Think of adulthood", new List<string>() { "Wat are the benefits of being an adult over being a child?", "Why is it generally considered immature to act like a child when you're grown if children are happy innocent creatures?", "Is it really right to be innocent as opposed to know right from wrong and make choices?"}}
        
    };
    
    public Reflecting(string chosenActivity, string describeActivity) : base(chosenActivity, describeActivity)
    {
        indx = randomPhrase.Next(0, _promptPhrase.Count);
    }

    public List<string> MagicPhrase()
    {
        List<string> keys = _promptPhrase.Keys.ToList();
        List<List<string>> values = _promptPhrase.Values.ToList();
        _magicPhrase = keys[indx];
        _magicQuestions = values[indx];
        //prints the magic phrase
        Console.WriteLine($"Consider the following prompt:\n--- {_magicPhrase} ---\n");
        Console.WriteLine("When you have something in mind, press `Enter` to continue.");
        Console.ReadLine();
        //returns questions associated with the magic phrase
        return _magicQuestions;
    }
    public void MagicQuestions()
    {
        _magicQuestions = MagicPhrase();
        Console.WriteLine("Now ponder on each of the following questions as they relate to the prompt. You may begin in: ");

        for (int i = 5; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
                Console.Write("\b\b \b");
            }

        Console.Clear();

        foreach(string _oneQuestion in _magicQuestions)
        {
            Console.Write($"> {_oneQuestion} ");
            int _sessionTime = GetChosenTime();
            int timeForquestion = _sessionTime/_magicQuestions.Count;
            GetSpinner(timeForquestion);
        }
    }
}
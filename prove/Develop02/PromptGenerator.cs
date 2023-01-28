using System;

public class PromptGenerator
{
    //List containing custom prompts to encourage the user.
    //Here it is considered that the reason the user often feels like not journaling
    //is because they are self-indulgent and would like something that helps them
    //build good habits.
    List<string> _encouragement = new List<string>()
    {
        "Your daily actions create your personality. Are you becoming someone all parts of your mind agree with?",
        "Would you describe small actions you can do right now that would can correct any mistake you have done in the past?",
        "What is something you did that made you feel competent today?",
        "Is there a hard problem you can break in small parts now, so that the solution might become clearer?",
        "What have you learned from the things that went wrong in your life?",
        "What have you learned from the things that went right in your life?",
        "Look around you, put something that isn't in order back in order and write down how it makes you feel?",
        "Without being unfair to others, How can you defend and assert yourself today?",
        "What are the first three steps to begin doing something helpful for you and others that yo can do today?",
        "What can you do to encourage the people you love to keep becoming better humans?"
    };
    
    public string ReturnPrompt(int number)
    {
        return _encouragement[number];
    }
}
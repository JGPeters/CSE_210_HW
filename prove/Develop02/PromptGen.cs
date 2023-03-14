public class PromtGen
{
    public List<string> prompts = new List<string> 
    {
    "What was your favorite part about today",
    "Where did you see the hand of the Lord in your life today?",
    "If you could change one thing about today what would it be?",
    "What do you think you could have done better today?",
    "How do you think today will afect tomorrow?"
    };

public string GetPrompt()
{
    Random rnd = new Random();
    int randIndex = rnd.Next(prompts.Count);
    string prompt = prompts[randIndex];
    return prompt;
}

}
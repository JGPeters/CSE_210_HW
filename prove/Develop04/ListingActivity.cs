public class ListingActivity : MindfullnessActivity
{
    List<string> _prompts = new List<string>{
        {"Who are people that you appreciate?"},
        {"What are personal strengths of yours?"},
        {"Who are people that you have helped this week?"},
        {"When have you felt the Holy Ghost this month?"},
        {"Who are some of your personal heroes?"}
    };
    List<string> _usedPrompts = new List<string>();
    List<string> _responses = new List<string>();
    public ListingActivity(string chosenActivity) :base(chosenActivity)
    {
        
    }

    private void ClearIfAllUsed()
    {
        if(_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }
    }

    private string GetPrompt()
    {
        ClearIfAllUsed();
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string prompt = _prompts[index];
        while(_usedPrompts.Contains(prompt))
        {
            index = rnd.Next(_prompts.Count);
            prompt = _prompts[index];
        }
        _usedPrompts.Add(prompt);
        return(prompt);
    }

    public void DoListing()
    {
       _responses.Clear();
       string prompt = GetPrompt();
       Console.Write($"List as many responses as you can to the following prompt:\n\n---{prompt}---\n\n");
       Console.Write("You may begin in: ");
       Console.Write("5");
       Wait1Sec();
       Console.Write("4");
       Wait1Sec();
       Console.Write("3");
       Wait1Sec();
       Console.Write("2");
       Wait1Sec();
       Console.Write("1");
       Wait1Sec();
       Console.WriteLine("");
       DateTime startTime = DateTime.Now;
       DateTime futureTime = startTime.AddSeconds(_chosenTime);
       do
       {
        Console.Write("> ");
        string response = Console.ReadLine();
        _responses.Add(response);
       }while(DateTime.Now < futureTime);
       Console.WriteLine($"You listed {_responses.Count} Items!");
       Console.WriteLine("");
    }
}

public class PromptGen
{

    public string getPrompt()
    {

        List<string> _prompts = new List<string>();

        _prompts.Add("What kind of day are you having, and why?");
        _prompts.Add("How can you show gratitude more?");
        _prompts.Add("Name a challenge you have overcome and how it helped you to grow.");
        _prompts.Add("Which people in your life are you most grateful for?");
        _prompts.Add("Write about something that made you smile today.");
        _prompts.Add("Did you make healthy choices today?");
        _prompts.Add("Are you feeling stressed?");

        // add items to the list
        Random r = new Random();
        int i = r.Next(_prompts.Count);

        string randomPrompt = _prompts[i];
        Console.WriteLine($"{randomPrompt}:");
        return randomPrompt;
    }
}
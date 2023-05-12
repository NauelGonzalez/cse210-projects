class ReflectActivity : Activity
{

    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectActivity()
    {
        SetActivityName("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _prompts.Add ("Think of a time when you stood up for someone else.");
        _prompts.Add ("Think of a time when you did something really difficult.");
        _prompts.Add ("Think of a time when you helped someone in need.");
        _prompts.Add ("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");


    }


    public void RunActivity()
    {
        Animation a = new Animation();
        WelcomeMsg();
        Console.Clear();
        Console.WriteLine("Get ready...");
        a.CountDown(5);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();

        Random rnd = new Random();

        Console.WriteLine($"   -----   {_prompts[rnd.Next(0, _prompts.Count-1)]}    -----") ;
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related is experience.");
        Console.WriteLine("You may begin in ");
        a.CountDown(5);
        Console.Clear();
        
        while (start < end){
                Console.WriteLine(_questions[rnd.Next(0, _questions.Count-1)]);
                a.Spinning(5);
                start = DateTime.Now;
        }

        FareWellMsg();

    }








}
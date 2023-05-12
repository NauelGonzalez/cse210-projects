class ListActivity : Activity
{


    private List<string> _questions = new List<string>();

    private List<string> _answers = new List<string>();
    public ListActivity()
    {
        SetActivityName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _questions.Add("Who are people that you appreciate?");
        _questions.Add("What are personal strengths of yours?");
        _questions.Add("Who are people that you have helped this week?");
        _questions.Add("When have you felt the Holy Ghost this month?");
        _questions.Add("Who are some of your personal heroes?");
    }


  public void RunActivity()
    {
        Animation a = new Animation();
        WelcomeMsg();
        Console.Clear();
        Console.WriteLine("Get ready...");
        a.Spinning(5);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();

        Random rnd = new Random();

        Console.WriteLine($"   -----   {_questions[rnd.Next(0, _questions.Count-1)]}    -----") ;
        Console.WriteLine();
        Console.WriteLine("You may begin in ");
        a.CountDown(5);
        int i = 1;
        while (start < end){
                Console.Write($"{i}-> ");
                _answers.Add(Console.ReadLine());
                start = DateTime.Now;
                i++;
        }
        Console.WriteLine($"You listed {_answers.Count()} items!");
        _answers = new List<string>();
        FareWellMsg();

    }



}
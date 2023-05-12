class BreathActivity : Activity
{




    public BreathActivity()
    {
        SetActivityName("Breathing");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
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
        
        while (start < end){
                Console.WriteLine();
                Console.WriteLine("Breathe in...");
                a.Arrows(4);
                Console.WriteLine();
                Console.WriteLine("and now breathe out...");
                a.Arrows(6);
                
                start = DateTime.Now;
        }
        FareWellMsg();

    }










}

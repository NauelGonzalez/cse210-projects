class Activity{

    // private string  _welcomeMsg;
    // private string _fareWellMsg;
    private string _activityName;
    private string _description;
    private int _duration;


    public Activity(){}

    
    public void WelcomeMsg (){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session?: ");
        SetDuration(int.Parse(Console.ReadLine()));

    }

    public void FareWellMsg(){
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have complete {_duration} seconds of {_activityName} activity");
        Console.ReadLine();
    }

    private void SetDuration(int duration){
        _duration = duration;
    }
    protected int GetDuration(){
        return _duration;
    }
    public void SetActivityName(string activityName){
        _activityName = activityName;
    }
    public void SetDescription (string description){
        _description = description;
    }

 
}
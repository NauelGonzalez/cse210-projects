class CheckListGoal : Goal
{

    private int _timesToComplete;
    private int _bonusPoints;

    public CheckListGoal(string goalName, string goalDescription, int goalPoints, DateTime dateCreated, DateTime dateExpected, bool completed, int timesCompleted, int timesToComplete, int bonusPoints) : base(goalName, goalDescription, goalPoints, dateCreated, dateExpected, completed, timesCompleted)
    {

        _timesToComplete = timesToComplete;
        _bonusPoints = bonusPoints;

    }

    public override void PrintGoal()
    {

        
        if ((GetDateExpected() - DateTime.Now).TotalDays < 0)
        {
            Console.Write($"[{(GetCompleted() ? "X" : " ")}] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed {GetTimesCompleted()}/{_timesToComplete}.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($" Goal expired on :{GetDateExpected().ToString("yyyy-MM-dd")}");
            Console.ResetColor();
        }
        else if ((GetDateExpected() - DateTime.Now).TotalDays < 2)
        {
            Console.Write($"[{(GetCompleted() ? "X" : " ")}] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed {GetTimesCompleted()}/{_timesToComplete}.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" Due date:{GetDateExpected().ToString("yyyy-MM-dd")}");
            Console.ResetColor();
        }
        else if ((GetDateExpected() - DateTime.Now).TotalDays < 10)
        {
            Console.Write($"[{(GetCompleted() ? "X" : " ")}] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed {GetTimesCompleted()}/{_timesToComplete}.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" Due date: {GetDateExpected().ToString("yyyy-MM-dd")}");
            Console.ResetColor();
        }

        else
        {
            Console.Write($"[{(GetCompleted() ? "X" : " ")}] {GetGoalName()} ({GetGoalDescription()}) -- Currently completed {GetTimesCompleted()}/{_timesToComplete}.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Due date: {GetDateExpected().ToString("yyyy-MM-dd")}");
            Console.ResetColor();
        }

    }


    public override string SaveLine()
    {
        return $"CheckListGoal|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints().ToString()}|{GetDateCreated().ToString("yyyy-MM-dd HH:mm:ss")}|{GetDateExpected().ToString("yyyy-MM-dd HH:mm:ss")}|{(GetCompleted() ? "1" : "0")}|{GetTimesCompleted()}|{_timesToComplete}|{_bonusPoints}";
    }

    public override void MarkCompleted()
    {
        if (GetCompleted())
        {
            Console.WriteLine("This goal is already completed");
        }
        else if (!GetCompleted() && DateTime.Now > GetDateExpected())
        {
            Console.WriteLine("This date is overdue and can't be completed now.");
        }
        else
        {
            if (GetTimesCompleted() < _timesToComplete)
            {
                SetCompleted(false);
                AddTimesCompleted(1);
                Console.WriteLine($"You earned {GetGoalPoints()} points.");
                if (GetTimesCompleted() == _timesToComplete)
                {
                    SetCompleted(true);
                    Console.WriteLine($"Congratulations! You completed the goal and earned an extra bonus of {_bonusPoints} points!!!");
                }
            }
        }
    }

    public override int CalculatePoints(){

        if (!GetCompleted() && DateTime.Now > GetDateExpected()){
            return  (GetGoalPoints() * GetTimesCompleted()) - (GetGoalPoints() * (_timesToComplete - GetTimesCompleted()));
        }
        else if (!GetCompleted() && DateTime.Now < GetDateExpected()){
             return  (GetGoalPoints() * GetTimesCompleted());
        }

        else if (GetCompleted()){
            return  (GetGoalPoints() * GetTimesCompleted()) + _bonusPoints;
            }
        else return 0;
    }


}
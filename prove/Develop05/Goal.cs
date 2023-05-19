public class Goal
{

    private string _goalName;
    private string _goalDescription;
    private DateTime _dateCreated;
    private DateTime _dateExpected;

    private int _goalPoints;
    private bool _completed;

    private int _timesCompleted;
    public Goal(string goalName, string goalDescription, int goalPoints, DateTime dateCreated, DateTime dateExpected, bool completed, int timesCompleted)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _dateCreated = dateCreated;
        _dateExpected = dateExpected;
        _completed = completed;
        _timesCompleted = timesCompleted;
    }
    public Goal(string goalName, string goalDescription, int goalPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _dateCreated = DateTime.Now;
        _dateExpected = DateTime.Now.AddDays(7);
        _completed = false;
        _timesCompleted = 0;
    }

    protected string GetGoalName()
    {
        return _goalName;
    }

    protected string GetGoalDescription()
    {
        return _goalDescription;
    }

    protected bool GetCompleted()
    {
        return _completed;
    }
    protected void SetCompleted(bool completed)
    {
        _completed = completed;
    }

    protected int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    protected void AddTimesCompleted(int timesCompleted)
    {
        _timesCompleted = _timesCompleted + timesCompleted;
    }

    protected int GetGoalPoints()
    {
        return _goalPoints;
    }

    protected DateTime GetDateCreated()
    {
        return _dateCreated;
    }


    protected DateTime GetDateExpected()
    {
        return _dateExpected;
    }

    public virtual void PrintGoal()
    {

        if ((GetDateExpected() - DateTime.Now).TotalDays < 0)
        {
            Console.Write($"[{(_completed ? "X" : " ")}] {_goalName} ({_goalDescription}).");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($" Goal expired on : {_dateExpected.ToString("yyyy-MM-dd")}");
            Console.ResetColor();
        }
        else if ((GetDateExpected() - DateTime.Now).TotalDays < 2)
        {
            Console.Write($"[{(_completed ? "X" : " ")}] {_goalName} ({_goalDescription}).");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" Due date: {_dateExpected.ToString("yyyy-MM-dd")}");
            Console.ResetColor();
        }
        else if ((GetDateExpected() - DateTime.Now).TotalDays < 10)
        {
            Console.Write($"[{(_completed ? "X" : " ")}] {_goalName} ({_goalDescription}).");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" Due date: {_dateExpected.ToString("yyyy-MM-dd")}");
            Console.ResetColor();
        }

        else
        {
            Console.Write($"[{(_completed ? "X" : " ")}] {_goalName} ({_goalDescription}).");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Due date: {_dateExpected.ToString("yyyy-MM-dd")}");
            Console.ResetColor();
        }

    }



    public virtual string SaveLine()
    {
        return $"Goal|{_goalName}|{_goalDescription}|{_goalPoints}|{_dateCreated.ToString("yyyy-MM-dd HH:mm:ss")}|{_dateExpected.ToString("yyyy-MM-dd HH:mm:ss")}|{(_completed ? "1" : "0")}|{_timesCompleted}";
    }

    public virtual void MarkCompleted()
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
            _completed = true;
            _timesCompleted = 1;
            Console.WriteLine($"You earned {GetGoalPoints()} points.");
        }
    }

    public virtual int CalculatePoints()
    {

        if (!GetCompleted() && DateTime.Now > GetDateExpected())
        {
            return _goalPoints * -1;
        }
        else if (GetCompleted())
        {
            return _goalPoints;
        }
        else return 0;
    }

}
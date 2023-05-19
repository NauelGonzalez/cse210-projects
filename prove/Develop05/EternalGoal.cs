class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDescription, int goalPoints, DateTime dateCreated, bool completed, int timesCompleted) : base(goalName, goalDescription, goalPoints, dateCreated, DateTime.Parse("3000-01-01"), completed, timesCompleted)
    {
    }

    public override void PrintGoal()
    {
        Console.WriteLine($"[ ] {GetGoalName()} ({GetGoalDescription()}).");

    }



    public override string SaveLine()
    {

        return $"EternalGoal|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints().ToString()}|{GetDateCreated().ToString("yyyy-MM-dd HH:mm:ss")}|{GetDateExpected().ToString("yyyy-MM-dd HH:mm:ss")}|{(GetCompleted() ? "1" : "0")}|{GetTimesCompleted()}";
    }
    public override void MarkCompleted()
    {
        SetCompleted(false);
        AddTimesCompleted(1);
        Console.WriteLine($"You earned {GetGoalPoints()} points.");
    }

        public override int CalculatePoints(){

        return GetGoalPoints() * GetTimesCompleted();
    }

}
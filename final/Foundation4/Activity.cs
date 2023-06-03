abstract class  Activity{

protected double _lenght;
protected DateTime _date;

    protected Activity(double lenght, DateTime date)
    {
        _lenght = lenght;
        _date = date;
       
    }


    protected string ConvertToMinSec(double value){
        
        // Use the timeSpan to show more accurate seconds information.
        TimeSpan t = TimeSpan.FromMinutes(value);
       return $"{Math.Truncate(t.TotalMinutes)}" + "." + t.Seconds.ToString();
    }
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract string CalculatePace();
    public abstract string GetSummary();

}
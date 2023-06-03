class Swim : Activity
{
    private double _laps;

    public Swim(double lenght, DateTime date, double laps) : base(lenght, date)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return (_laps * 50) /1000;
    }

    public override string CalculatePace()
    {
        return ConvertToMinSec(_lenght / CalculateDistance());
    }

    public override double CalculateSpeed()
    {
        return (CalculateDistance()/_lenght)*60;
    }

      public override string GetSummary()
    {
       return $"{_date.ToString("dd MMM yyyy")} Running ({_lenght} min) - Distance {CalculateDistance().ToString()} Km, Speed: {CalculateSpeed().ToString()} Kph, Pace: {CalculatePace()} min per Km";
    }


}
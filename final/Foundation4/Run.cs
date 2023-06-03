class Run : Activity
{
    private double _distance;

    public Run(double lenght, DateTime date, double distance) : base(lenght, date)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override string CalculatePace()
    {
        return ConvertToMinSec(_lenght / _distance);
    }

    public override double CalculateSpeed()
    {
        return (_distance / _lenght)*60;
    }

      public override string GetSummary()
    {
       return $"{_date.ToString("dd MMM yyyy")} Running ({_lenght} min) - Distance {_distance.ToString()} Km, Speed: {CalculateSpeed().ToString()} Kph, Pace: {CalculatePace()} min per Km";
    }


}
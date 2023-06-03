class Bicycle : Activity
{
    private double _speed;

    public Bicycle(double lenght, DateTime date, double Speed) : base(lenght, date)
    {
        _speed = Speed;
    }

    public override double CalculateDistance()
    {
        return (_speed * _lenght) /60;
    }

    public override string CalculatePace()
    {
        return ConvertToMinSec(60 / _speed);
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

      public override string GetSummary()
    {
       return $"{_date.ToString("dd MMM yyyy")} Running ({_lenght} min) - Distance {CalculateDistance().ToString()} Km, Speed: {CalculateSpeed().ToString()} Kph, Pace: {CalculatePace()} min per Km";
    }


}
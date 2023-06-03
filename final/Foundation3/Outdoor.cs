class Outdoor : Event
{

    private string _weather ;

    public Outdoor(string title, string description, DateTime date, TimeSpan time, string address, string weather) : base(title, description, date, time, address)

    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return StandardDetails() + $"\n\nOutdoor event\nWeather forecast: {_weather}";
    }
        public override string GetShortDescription()
    {
         return "Outdoor - "+ ShortDescription();
    }
    
}
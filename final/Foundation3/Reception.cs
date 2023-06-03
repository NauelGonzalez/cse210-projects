class Reception : Event
{

    private string _rsvp ;

    public Reception(string title, string description, DateTime date, TimeSpan time, string address, string RSVP) : base(title, description, date, time, address)

    {
        _rsvp = RSVP;
    }

    public override string GetFullDetails()
    {
        return StandardDetails() + $"\n\nReception event\nPlease confirm to: {_rsvp}";
    }
        public override string GetShortDescription()
    {
         return "Reception - "+ ShortDescription();
    }
    
}
class Conference : Event
{
    private string speakerName;
    private int capacity;

    public Conference(string title, string description, DateTime date, TimeSpan time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        this.speakerName = speakerName;
        this.capacity = capacity;
    }

    public override string GetSpecificDetails()
    {
        return $"Speaker: {speakerName}\nCapacity: {capacity}";
    }
}

class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetSpecificDetails()
    {
        return $"RSVP Email: {rsvpEmail}";
    }
}

class OutdoorMeeting : Event
{
    private string weatherForecast;

    public OutdoorMeeting(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetSpecificDetails()
    {
        return $"Weather forecast: {weatherForecast}";
    }
}

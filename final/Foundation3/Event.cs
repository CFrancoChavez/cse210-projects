class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"{title}\n{description}\n{date.ToShortDateString()} at {time.ToString(@"hh\:mm")} {address}";
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: {GetType().Name}\n{GetSpecificDetails()}";
    }

    public virtual string GetSpecificDetails()
    {
        return "";
    }

    public string GetBriefDescription()
    {
        return $"{GetType().Name}: {title}, {date.ToShortDateString()}";
    }
}

class Outdoor:Event{
    private string _weather;

// Methods
    public override string DisplayFullDescription(){
        return $"{base.DisplayFullDescription()}Outdoor Gathering\n{_weather}";
    }

// Setters
    public Outdoor(string weather, string title, string description, string date, string time, Address address)
    : base(title, description, date, time, address)
    {
        _weather = weather;
    }
}
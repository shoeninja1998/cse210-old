class Event{
// Objects
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

// Methods
    public virtual string DisplayFullDescription(){
        return $"{DisplayStandardDescription()}\n";
    }
    public virtual string DisplayStandardDescription(){
        return $"{_title}\n{_description}\n\n{_date}, {_time}\n{_address.GetAddress()}\n";
    }
    public string DisplayShortDescription(){
        return $"{_title}\n{_date}";
    }

// Getters & Setters
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
}
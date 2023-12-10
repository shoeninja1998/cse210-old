class Reception:Event{
    private string _email;
// Methods
    public override string DisplayFullDescription(){
        return $"{base.DisplayFullDescription()}Reception\nRSVP Email: {_email}";
    }
// Setters
    public Reception(string email, string title, string description, string date, string time, Address address)
    : base(title, description, date, time, address)
    {
        _email = email;
    }
}
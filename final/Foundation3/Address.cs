class Address{
// Objects
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _zipCode;

// Methods
    public string GetAddress(){
        return $"{_street}, {_city}, {_state}, {_zipCode}, {_country}";
    }

// Getters & Setters
    public Address(string street, string city, string state, string zipCode, string country){
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }
    
}

class Lecture : Event{
// Objects
    private string _speaker;
    private int _capacity;

// Methods
    public override string DisplayFullDescription(){
        return $"{base.DisplayFullDescription()}Lecture by {_speaker}\nCapacity of {_capacity};";
    }

// Getters & Setters
    public Lecture(string speaker, int capacity, string title, string description, string date, string time, Address address)
        : base(title, description, date, time, address){
            _speaker = speaker;
            _capacity = capacity;
    }
}
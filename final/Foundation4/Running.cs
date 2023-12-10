class Running:Activity{
    private double _distance;

// Methods
    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running ({_duration}) - Distance : {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
    public override double GetSpeed()
    {
        return _distance / _duration * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

// Setter
    public Running(int distance, string date, int duration)
    :base(date, duration)
    {
        _distance = distance;
    }

}
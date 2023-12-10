class Swimming:Activity{
    private int _laps;

// Methods
    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming ({_duration}) - Distance : {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
    public override double GetDistance()
    {
        return _laps * 50/1000;
    }
    public override double GetPace()
    {
        return _duration / GetDistance();
    }

    // Setter
    public Swimming(int laps, string date, int duration)
    :base(date, duration)
    {
        _laps = laps;
    }
}
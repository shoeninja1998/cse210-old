class Cycling:Activity{
    private double _speed;

// Methods
    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling ({_duration}) - Distance : {GetDistance()} miles, Speed: {_speed} mph, Pace: {GetPace()} min/mile";
    }
    public override double GetDistance()
    {
        return _duration * _speed / 60; 
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }

    // Setter
    public Cycling(double speed, string date, int duration)
    :base(date, duration)
    {
        _speed = speed;
    }
}
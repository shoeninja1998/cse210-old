class Activity{
    private string _date;
    protected int _duration;

// Methods
    public virtual string GetSummary(){
        return $"{_date}";
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed(){
        return 0;
    }
    public virtual double GetPace(){
        return 0;
    }
    
// Setter
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }
}
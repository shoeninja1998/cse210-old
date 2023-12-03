class Exercise{
    protected int _duration;
    public int Duration {
        get {return _duration;}
        set {_duration = value;}
    }
    protected string _exercise = "";
    private string _message = "";
    public void SetMessage(string message){
       _message = message;
    }
    public void DisplayMessage(){
        Console.Write(_message);
    }
    public void SetDuration(int duration){
        _duration = duration;
    }
    public string GetMessage(){
        return _message;
    }

    public void DisplayTimer(){
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Console.Write("\b \b");
    }
    // public void SetExercise(string chosenExercise){
    //     _exercise = chosenExercise;
    // }
}
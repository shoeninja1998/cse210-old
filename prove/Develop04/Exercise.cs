class Exercise{
    private int duration;
    private string exercise = "";
    private string finish = "All finished. Good job!";
    private string message = "";

    public Exercise(string finish, string message){
        Console.WriteLine("Exercise complete. Good job!");
    }

    public void SetMessage (int duration){
       message = $"You did the {exercise} for {duration} long.";
    }
    public string GetMessage(){
        return message;
    }
    public void SetExercise(string chosenExercise){
        exercise = chosenExercise;
    }
}
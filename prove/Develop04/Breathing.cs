using System.Diagnostics.Metrics;
using System.Threading;

class Breathing:Exercise{
    private string breathingMessage = @"This activity will help you relax by walking your through breathing in and out slowly.
        Clear your mind and focus on your breathing.";
    public static System.Timers.Timer timer;
    public int duration;

    public Breathing(string finish, string message, System.Timers.Timer timer, int duration):base(finish, message)
    {
        // Create a timer with a 1000ms (1 second) interval
        timer = new System.Timers.Timer(1000)
        {
            // Set the timer to only go once (false for recurring)
            AutoReset = true
        };

        // Hook up the Elapsed event handler
        timer.Elapsed += StartBreathingExercise;

        // Start the timer
        timer.Enabled = true;
    }

    public void StartBreathingExercise(object source, ElapsedEventArgs e)
    {
        while (e.SignalTime.Second != duration)
        {
            int counter = 4;
            while(counter != 0){
                
                Console.WriteLine($"Breathe in... ({counter})");
                Thread.Sleep(1000);
                counter -= 1;

            }

            while(counter != 0){
                
                Console.WriteLine($"Breathe out... ({counter})");
                Thread.Sleep(1000);
                counter -= 1;

            }
            
            }
        } 

        // The exercise should be complete when the while loop breaks
}

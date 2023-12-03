class Breathing:Exercise{
    private string _breathingMessage = @"This activity will help you relax by walking your through breathing in and out slowly.
Clear your mind and focus on your breathing.";
    public void BreathingExercise(){
        Console.WriteLine(_breathingMessage);
            int counter = 4;
        while (_duration != 0){

            while(counter != 0){

                Console.WriteLine($"Breathe in... ({counter})");
                Thread.Sleep(1000);
                counter -= 1;

            }
        // Holding your breath
        Thread.Sleep(2000);
        counter = 4;
            while(counter != 0){
                
                Console.WriteLine($"Breathe out... ({counter})");
                Thread.Sleep(1000);
                counter -= 1;

            }
        }
    }
} 
    // The exercise should be complete when the while loop breaks

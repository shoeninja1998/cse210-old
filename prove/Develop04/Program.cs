class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int chosen = 0;
        while (chosen != 4)
        {
            // exercise.DisplayTimer();
            Console.Write(@"Hello, what exercise would you like to do? 
            1. Breathing
            2. Reflection
            3. Listing
            4. Quit
    ");
            chosen = int.Parse(Console.ReadLine());
        
            
            
            switch(chosen){
                case 1:
                    Breathing breathing = new();
                    
                    breathing.Duration = GetDuration();
                    breathing.BreathingExercise();
                    // string exercise1 = "Breathing Exercise";
                    // exercise.SetExercise(exercise1);
                    int value = breathing.Duration;

                    break;

                case 2:
                    Reflection reflection = new();
                    reflection.Duration = GetDuration();
                    // string exercise2 = "Reflection Exercise";
                    // exercise.SetExercise(exercise2);


                    break;

                case 3:
                    Listing listing = new();
                    listing.Duration = GetDuration();
                    string prompt = listing.GetPrompt();
                    listing.ListingExercise(prompt);
                    // string exercise3 = "Listing";
                    // exercise.SetExercise(exercise3);

                    break;
            }
        }
    }

    static int GetDuration()
    {
        // Sets duration of the exercise
        Console.Write("How long would you like the exercise to be? (Seconds): ");
        return int.Parse(Console.ReadLine());
    }
}
class Listing: Exercise{

    public Listing()
    {

    }
    private string _listingMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public string GetPrompt(){
        Random random = new();
        var random_int = random.Next(0, _prompts.Count);
        var prompt = _prompts[index: random_int];

        return prompt;
    }
    public void ListingExercise(string prompt) {
        List<string> entry_list = new();
        Console.Write($@"{_listingMessage}
Press any key for a prompt!");
        Console.ReadLine();
        Console.Clear();
        Console.Write($@"{prompt}
Press any key to continue.
");
        Console.ReadLine();

        // "Think about it..." animation.
            Console.Write($"Think about it");
            for (int i=3; i>0; i--){
            Thread.Sleep(1000);
            Console.Write(".");
        }
        // Starts the timer, checks time only when an entry was 
        DateTime startTime = DateTime.Now;
        DateTime currentTime = startTime;
        DateTime futureTime = startTime.AddSeconds(_duration);
        
        Console.WriteLine("Go!");
        Console.Write("> ");
        while (currentTime <= futureTime){
            // Console.WriteLine($"startTime: {startTime}, currentTIme: {currentTime}, futureTime: {futureTime}");
            // Console.WriteLine(_duration);
            // Console.Write("");

            if (Console.KeyAvailable)
            {
                string entry = Console.ReadLine();
                entry_list.Add(entry);
                Console.Write("> ");
            }
            currentTime = DateTime.Now; // update time
        }

        Console.WriteLine("\nTime's up!");
        foreach(string entry in entry_list){
            Console.WriteLine(entry);
        }
    }
}
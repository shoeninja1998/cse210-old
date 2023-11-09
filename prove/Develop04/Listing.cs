class Listing: Exercise{
    private List<string> Prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public string GetPrompt(){
        Random random = new();
        var random_int = random.Next(0, Prompts.Count);
        var prompt = Prompts[index: random_int];

        return prompt;
    }
}
class Reflection: Exercise{
    private List<string> Prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> Reflections = new()
    {
        "Why was this experience meaningful to you?",  
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public string GetPrompt(){
        Random random = new();
        var random_int = random.Next(0, Prompts.Count);
        var prompt = Prompts[index: random_int];

        return prompt;
    }

    public string GetReflection(){
        Random random = new();
        var random_int = random.Next(0, Reflections.Count);
        var reflection = Reflections[index: random_int];
        
        return reflection;
    }
}
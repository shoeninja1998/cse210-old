class Reflection: Exercise{
    private string _reflectionMessage = "This activity will help you reflect on times in your life " +
    "when you have shown strength and resilience. This will help you recognize the power you have " +
    "and how you can use it in other aspects of your life.";
    private List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflections = new()
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

    public void ReflectionExercise(){
        Console.WriteLine(_reflectionMessage);
    }
    public string GetPrompt(){
        Random random = new();
        var random_int = random.Next(0, _prompts.Count);
        var prompt = _prompts[index: random_int];

        return prompt;
    }
    public string GetReflection(){
        Random random = new();
        var random_int = random.Next(0, _reflections.Count);
        var reflection = _reflections[index: random_int];
        
        return reflection;
    }
}
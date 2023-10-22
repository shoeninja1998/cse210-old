public class selectPrompt{
        List<string> prompts = new()
        {
        "Was there a new person you met today?",
        "What did you accomplish today?",
        "Have you seen my dog?",
        "What are you looking forward to this week?",
        "What was a good thing that happened today?"
        };

        var random = new Random();
        int index = random.Next(prompts.Count);
        string selected_prompt = prompts[index];

        return selected_prompt;
    }
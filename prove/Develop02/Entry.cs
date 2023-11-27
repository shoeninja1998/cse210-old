using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.IO.Enumeration;

public class Entry{
    public string _date;
    private string _prompt;
    private string _entry;
    private List<string> _prompts = new(){
                "\nWas there a new person you met today? ",
                "\nWhat did you accomplish today? ",
                "\nHave you seen my dog? ",
                "\nWhat are you looking forward to this week? ",
                "\nWhat was a good thing that happened today? "
                };

    public void GetPrompt(){
        Random random = new();
        int index = random.Next(_prompts.Count);
        _prompt = _prompts[index];
    }
    public void GetEntry(){
        Console.Write($"{_prompt}");
        _entry = Console.ReadLine();
        _date = $"{DateTime.Now}";
    }

    public string CompleteEntry(){
        return $"\nDate: {_date} - Prompt: {_prompt}\n{_entry}";
    }
}
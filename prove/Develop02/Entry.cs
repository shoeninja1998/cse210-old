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

    public List<string> RemoveEntry(List<string> journal){
        if(journal.Count != 0){
        Console.Write(@"Which entry would you like to remove?
");
        int entryIndex = int.Parse(Console.ReadLine()) - 1;
        journal.RemoveAt(entryIndex);
        Console.WriteLine("The entry has been removed.");
        }

        else{
            Console.WriteLine("There are no entries to remove!");
        }
        return journal;

    }
}
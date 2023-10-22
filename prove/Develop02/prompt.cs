using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;

public class Entry{
    public string _date;
    public string _prompt;
    public string _entry;

    public string CompletePrompt(){
        return _date + "Prompt: " + _prompt + _entry;
    }
}
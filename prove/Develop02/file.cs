public class File{
    public string _fileName;
    
    public void DisplayJournal(List<string> journal){

    foreach(string entry in journal){
        Console.WriteLine($"{entry}");
    }
    Console.Write(@"Press Enter to Exit.
");
    // while(Console.ReadKey != ConsoleKeyInfo.Enter){
    // } 
    }
    public List<string> LoadFile(){
    string[] lines = System.IO.File.ReadAllLines(_fileName);
    List<string>loaded = new();

    foreach (string line in lines)
    {
        loaded.Add(line);
    }
        return loaded;
    }
        
        
    public void SaveFile(List<string> _journal){
        // Create a writer object in the chosen file
        using StreamWriter writer = new(_fileName, true);

        //Save what's in the journal to the file
        foreach(string _entry in _journal){
            writer.WriteLine(_entry);
        }
        
        Console.WriteLine("The file has been saved.");

    }
}
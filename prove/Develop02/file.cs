public class File{
    public string _fileName;
    
    public void DisplayJournal(List<string> journal){
        // Iterates through each entry in the journal
        if (journal.Count != 0){
            int entry_num = 0;
        foreach(string entry in journal){
            entry_num += 1;
            Console.WriteLine($@"{entry_num}. {entry}");
        }
        }
        else{
            Console.WriteLine("The journal is empty!");
        }
        

        }
    public List<string> LoadFile(){
        // Add all lines of a file to an array
        List<string>loaded = new();

        // Checks to see that the file exists
        if(System.IO.File.Exists(_fileName)){
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        
        // Add each line of the array to a list
        foreach (string line in lines)
        {
            loaded.Add(line);
        }
        Console.WriteLine("File successfully loaded!");
        }
        // If the file isn't found
        else{
            Console.WriteLine("File not found!");
            loaded = null;
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
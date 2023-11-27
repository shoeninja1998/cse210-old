class Program
{
    static void Main(string[] args)
    {
        List<string> _journal = new();

        while(true){
        Console.Write(@"
What would you like to do?
1. Write a new entry
2. Display journal
3. Load the journal from a file
4. Save the journal to a file
5. Quit
");

        int user_input = int.Parse(Console.ReadLine());
        Entry entry = new();
        File file = new();
        switch(user_input)
        {
        case 1:
        // Write a new entry
            entry.GetPrompt();
            entry.GetEntry();
            string complete_entry = entry.CompleteEntry();
            _journal.Add(complete_entry);

            break;
            
        case 2:
        // Display journal
            if (_journal != null){
                file.DisplayJournal(_journal);
            }
            else{
                Console.WriteLine("The journal is currently empty!");
            }
            
            
            break;

        case 3:
        // Loading
            Console.Write("What is the name of the file? ");
            file._fileName = Console.ReadLine();
            _journal = file.LoadFile();
           
            break;

        case 4:
        // Saving
            Console.Write("What is the name of the file? ");
            file._fileName = Console.ReadLine();
            file.SaveFile(_journal);

            break;

        case 5:
            
            break;
            }
        }
    }
}
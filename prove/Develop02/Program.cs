class Program
{
    static void Main(string[] args)
    {
        List<string> journal = new();
        bool looping = true;
        while(looping){
        Console.Write(@"
What would you like to do?
1. Write a new entry
2. Remove an existing entry
3. Display journal
4. Load the journal from a file
5. Save the journal to a file
6. Quit
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
            journal.Add(complete_entry);

            break;
            
        case 2:
        // Remove an existing entry
            file.DisplayJournal(journal);
            entry.RemoveEntry(journal);
            Console.Write("Press any key to Exit.");
            Console.ReadLine();
            
            break;

        case 3:
        // Display journal
            file.DisplayJournal(journal);
            Console.Write("Press any key to Exit.");
            Console.ReadLine();
            
            break;

        case 4:
        // Loading
            Console.Write("What is the name of the file? ");
            file._fileName = Console.ReadLine();
            journal = file.LoadFile();

            Console.Write("Press any key to Exit.");
            Console.ReadLine();
           
            break;

        case 5:
        // Saving
            Console.Write("What is the name of the file? ");
            file._fileName = Console.ReadLine();
            file.SaveFile(journal);

            break;

        case 6:
            looping = false;
            break;
            }
        }
    }
}
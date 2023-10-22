using System;

class Program
{
    static void Main(string[] args)
    {
        Reference John316 = new();
        Text John316_Text = new();
        Word John316_Word = new();

        string scripture = John316.Scripture();
        string text = John316_Text.DisplayText();

        Console.WriteLine("Welcome to the Scripture Memorizer! Press Enter to see your first scripture. ");
        List<int> chosenIndexes = new();

        while (true)
        {
            // Checks to see if Enter was pressed
            string input = Console.ReadLine();
            if (input == "")
            {
                Console.Clear();
                Console.WriteLine($"{scripture}: {text}");
                break;
            }
        }

        while (true)
        {
            // Checks to see if Enter was pressed
            Console.WriteLine("");
                string input = Console.ReadLine();
            
            if (input == ""){

                // Clears the console
                Console.Clear();

                string modifiedText = John316_Word.RemoveWord(text, chosenIndexes);
                
                text = modifiedText;

                // Displays modified scripture
                Console.WriteLine($"{scripture}: {modifiedText}");
                }
            
            // Checks for the word quit
            else if (input.ToLower() == "quit"){
                break;
            }
        }
    }
}
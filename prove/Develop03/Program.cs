using System;

class Program
{
    static void Main(string[] args)
    {
        Reference John3_16 = new()
        {
            _book = "John",
            _chapter = 3,
            _verse = "16",
            _text = @"For God so loved the world, that he gave his only begotten Son,
       that whosoever believeth in him should not perish, but have everlasting life."
        };

        string scripture = John3_16.Scripture();
        string text = John3_16.Text();

        Console.WriteLine("Welcome to the Scripture Memorizer! Press Enter to see your first scripture. ");

        while (true)
        {
            // Checks to see if Enter was pressed
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine($"{scripture}: {text}");
                break;
            }
        }

        while (true)
        {
            // Checks to see if Enter was pressed
            List<int> chosenIndexes = new();

            Console.WriteLine("");
                string input = Console.ReadLine();
            
            if (input == ""){
                // Clears the console
                Console.Clear();

                string[] words = text.Split(' ');

                // Selects how many words will be modified
                Random random = new();
                int numWords = random.Next(2,3);
                Console.WriteLine(numWords);

                // Loops as many times as the number of words selected; each iteration modifies 1 word

                for (int i = 0; i < numWords; i++)
                {
                    // Chooses the word to be modified
                    int randomIndex = random.Next(0, words.Length);
                    Console.WriteLine($"{randomIndex} Random Index");

                    // Ensures the word hasn't already been modified
                    while (chosenIndexes.Contains(randomIndex)){
                        randomIndex = random.Next(0, words.Length);
                    }

                    chosenIndexes.Add(randomIndex);
                    foreach(int index in chosenIndexes){
                        Console.WriteLine(index);
                    }
                    
                    // Replaces each letter in the chosen words with an underscore
                    words[randomIndex] = new string('_', words[randomIndex].Length);
                }

                // Recombines the modified words into one string
                string modifiedText = string.Join(" ", words);
                
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
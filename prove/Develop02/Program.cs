using System;
using System.IO;
using System.Xml.Serialization;


class Program
{
    static void Main(string[] args)
    {
        Console.Write(@"What would you like to do?
        1. Write a new entry
        2. Display previous entries
        3. Load the previous entries
        4. Save entries
        ");

        int user_input = int.Parse(Console.ReadLine());
        switch(user_input)
        {
        case 1:
            Entry placeholder = new Entry();

            placeholder._date = "Date: " + DateTime.Now;
            Console.WriteLine($"{placeholder._date}");

            List<string> prompts = new(){
                "Was there a new person you met today?",
                "What did you accomplish today?",
                "Have you seen my dog?",
                "What are you looking forward to this week?",
                "What was a good thing that happened today?"
                };

            Random random = new();
            int index = random.Next(prompts.Count);
            
            // Selects a random prompt from the list
            placeholder._prompt = prompts[index];
            
            Console.Write(placeholder._prompt);
            
            placeholder._entry = Console.ReadLine();

            // Path to your text file
            string filePath = "prompt.txt";
            // Append to the file
            using (StreamWriter sw = new StreamWriter(filePath, true)){
                string textToAdd = "";
                // Write the string to the file
                sw.WriteLine(textToAdd);
                break;
            }

        case 2:

            break;
        case 3:
            break;
        }
        

    // Grab name, date, and entry number
        static Tuple<string, string, int> header(){
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("What is the date? ");
            string date = Console.ReadLine();

            Console.Write("What is the entry number? ");
            int entry_num = int.Parse(Console.ReadLine());

            var entry_info = new Tuple<string, string, int>(name, date, entry_num);

            return entry_info; 
        }

    }
}
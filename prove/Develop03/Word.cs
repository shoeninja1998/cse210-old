public class Word{
    public string RemoveWord(string text, List<int> chosenIndexes){
        string[] words = text.Split(' ');

                // Selects how many words will be modified
                Random random = new();
                int numWords = random.Next(2,3);

                for (int i = 0; i < numWords; i++)
                {

                    // Ensures the word hasn't already been modified
                    while (true){
                        int randomIndex = random.Next(0, words.Length);
                        if (!chosenIndexes.Contains(randomIndex)){
                            
                            // Adds the word to the list
                            chosenIndexes.Add(randomIndex);
                            
                            // Replaces each letter in the chosen words with an underscore
                    words[randomIndex] = new string('_', words[randomIndex].Length);
                            break;
                        }
                    }
                }

                // Recombines the modified words into one string
                string modifiedText = string.Join(" ", words);
        return modifiedText;
    }
}
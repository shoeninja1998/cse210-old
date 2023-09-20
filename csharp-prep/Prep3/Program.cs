using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        bool correct_guess = false;

        Random randomGenerator = new Random();
        int correct_number = randomGenerator.Next(1,10);

        while(correct_guess == false){
        
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int number = int.Parse(guess);

        if(number > correct_number){
            Console.WriteLine("The correct number is smaller.");
        }
        else if(number < correct_number){
            Console.WriteLine("The correct number is bigger.");
        }
        else{
            Console.WriteLine("You guessed the number!");
            correct_guess = true;
        }
        }
    }
}
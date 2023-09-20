using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();

        int square_num = SquareNumber(number);

        DisplayResult(name, square_num);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square_num = number * number;
        return square_num;
    }
    
    static void DisplayResult(string name, int square_num)
    {
        Console.WriteLine($"{name}, your favorite number squared is {square_num}.");
    }

}

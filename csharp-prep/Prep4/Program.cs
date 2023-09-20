using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
    List<int> numbers = new List<int>{};
    int current_number = 1;

        Console.Write("What number would you like to add to the list? ");
    
        do
        {
            Console.Write("What is the next number? Enter '0' to stop. ");

            string written_number = Console.ReadLine();
            current_number = int.Parse(written_number);
            numbers.Add(current_number);

            Console.WriteLine("The number has been added.");

        } while (current_number != 0);
        
        int total_numbers = numbers.Count();
        float sum_numbers = numbers.Sum();
        float avg_numbers = sum_numbers/total_numbers;
        int max_numbers = numbers.Max();

        Console.WriteLine($"The sum of the numbers is {sum_numbers}.");
        Console.WriteLine($"The average of the numbers is {avg_numbers}.");
        Console.WriteLine($"The biggest number is {max_numbers}.");
    }
}
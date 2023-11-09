using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(@"Hello, what exercise would you like to do? 
        1. Breathing
        2. Reflection
        3. Listing");

        var chosen = int.Parse(Console.ReadLine());

        Exercise exercise = new();

        switch(chosen){
            case 1:
                string exercise1 = "Breathing Exercise";
                exercise.SetExercise(exercise1);
                break;

            case 2:
                string exercise2 = "Reflection Exercise";
                exercise.SetExercise(exercise2);
                break;

            case 3:
                string exercise3 = "Listing";
                exercise.SetExercise(exercise3);
                break;
        }


    }
}
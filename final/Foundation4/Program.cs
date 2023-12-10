using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new()
        {
            new Running(30, "November 20, 2022", 30),
            new Cycling(60, "August 8, 2016", 30),
            new Swimming(120, "March 23, 2019", 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
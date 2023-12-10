using System;

class Program
{
    static void Main(string[] args)
    {
         // Example usage
        Address address1 = new("123 Main St", "Cityville", "State", "12345","Algeria");
        Lecture lectureEvent = new("Dr. Smith", 100, "How do you breathe?", "A lecture on the breathing process", "2023-01-15", "12:30pm", address1);

        Address address2 = new("456 Oak St", "Townsville", "State", "54321","Brazil");
        Reception receptionEvent = new("rsvp@example.com", "Networking Reception", "An opportunity to network", "2023-02-20", "6:30pm", address2);

        Address address3 = new("789 Pine St", "Villageton", "State", "67890","New Zealand");
        Outdoor outdoorEvent = new("Good Weather", "Summer Picnic", "An international picnic event", "2023-06-10", "12:00pm", address3);

        Event[] events = { lectureEvent, receptionEvent, outdoorEvent };

        foreach (var e in events)
        {
            Console.WriteLine($"\nShort Description:");
            Console.WriteLine(e.DisplayShortDescription());

            Console.WriteLine("\nStandard Description:");
            Console.WriteLine(e.DisplayStandardDescription());

            Console.WriteLine("\nFull Description:");
            Console.WriteLine(e.DisplayFullDescription());

        }
    }
}
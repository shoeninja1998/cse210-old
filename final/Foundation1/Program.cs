using System;
using Foundation1;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new()
        {
            Title = "1 Million Dollars!",
            Author = "MrBeast",
            Length = 6030
        };

        Video video2 = new()
        {
            Title = "Chugging the Ocean",
            Author = "BadlandsChugs",
            Length = 730
        };

        Video video3 = new()
        {
            Title = "1 Million Dollars",
            Author = "",
            Length = 30
        };
    }
}
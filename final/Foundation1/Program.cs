using System;
using System.ComponentModel.DataAnnotations;
using Foundation1;

class Program
{
    static void Main(string[] args)
    {
        Comment video1Comment1 = new(){
            _name = "Brad",
            _text = "Nice video! Could I get some of that money?"
        };
        Comment video1Comment2 = new(){
            _name = "Marlton",
            _text = "Bah, I find this video to be rather mediocre."
        };
        Comment video1Comment3 = new(){
            _name = "Macie",
            _text = "do a bigger giveaway next time"
        };
        Comment video2Comment1 = new(){
            _name = "John",
            _text = "I knew he couldn't actually chug the ocean."
        };
        Comment video2Comment2 = new(){
            _name = "Mike",
            _text = "shut up john"
        };
        Comment video2Comment3 = new(){
            _name = "Bill",
            _text = "Impressive!"
        };
        Comment video3Comment1 = new(){
            _name = "suparapgangsta",
            _text = "I agree with all of your points. Like!"
        };
        Comment video3Comment2 = new(){
            _name = "Benny",
            _text = "I disagree with all of your points. Dislike!"
        };
        Comment video3Comment3 = new(){
            _name = "jason",
            _text = "I partially agreed with your points."
        };

        Video video1 = new()
        {
            _title = "1 Million Dollars!",
            _author = "MrBeast",
            _length = 6030,
            _comment1 = video1Comment1,
            _comment2 = video1Comment2,
            _comment3 = video1Comment3
        };
        video1.DisplayVideo();

        Video video2 = new()
        {
            _title = "Chugging the Ocean",
            _author = "BadlandsChugs",
            _length = 730,
            _comment1 = video2Comment1,
            _comment2 = video2Comment2,
            _comment3 = video2Comment3
        };
        video2.DisplayVideo();

        Video video3 = new()
        {
            _title = "Youtube Video Essay",
            _author = "Artist",
            _length = 30,
            _comment1 = video3Comment1,
            _comment2 = video3Comment2,
            _comment3 = video3Comment3
        };
        video3.DisplayVideo();
    }
}
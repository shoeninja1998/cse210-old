namespace Foundation1
{
    public class Video
    {
        public string _title;
        public string _author;
        public int _length;
        public Comment _comment1;
        public Comment _comment2;
        public Comment _comment3;

    // Methods
        public void DisplayVideo(){
            Console.WriteLine(@$"{_title} by {_author}, {_length} seconds long.
Comments:
{_comment1._name}:
{_comment1._text}

{_comment2._name}:
{_comment2._text}

{_comment3._name}:
{_comment3._text}
");
        }
    }
}
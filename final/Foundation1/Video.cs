namespace Foundation1
{
    public class Video
    {
        // Video title
        private string _title;
        public string Title{
            get{return _title;}
            set{_title = value;}
        }
        // Video author
        private string _author;
        public string Author{
            get{return _author;}
            set{_author = value;}
        }
        // Video length
        private int _length;
        public int Length{
            get{return _length;}
            set{_length = value;}
        }
    }
}
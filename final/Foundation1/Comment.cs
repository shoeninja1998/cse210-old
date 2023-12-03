namespace Foundation1
{
    public class Comment
    {
        // Comment writer's name
        private string _name;
        public string Name{
            get{return _name;}
            set{_name = value;}
        }
        // Comment Text
        private string _text;
        public string Text{
        get{return _text;}
        set{_text = value;}
    }
        // Comment's Original Video
        private string _video;
        public string Video{
            get{return _video;}
            set{_video = value;}
        }
    }
}
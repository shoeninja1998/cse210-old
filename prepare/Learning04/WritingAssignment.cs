class WritingAssignment : Assignment{
    private string _title = "";

    public void SetTitle(string title)
    {
        _title = title;
    }

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic){
            _title = title;
        }
}
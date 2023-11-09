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
        public string WritingInformation()
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}
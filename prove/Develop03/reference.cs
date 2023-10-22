public class Reference{
private string _book = "John";
private int _chapter = 3;
private string _verse = "16";

    public string Scripture(){
        return $"{_book} {_chapter}:{_verse}";
    }
}
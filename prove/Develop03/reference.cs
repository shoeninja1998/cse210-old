public class Reference{
public string _book;
public int _chapter;
public string _verse;
public string _text;

    public string Scripture(){
        return $"{_book} {_chapter}:{_verse}";
    }
    public string Text(){
        return $"{_text}";
    }
}
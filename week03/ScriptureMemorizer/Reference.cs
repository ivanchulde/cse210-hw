public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;

    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return _endVerse > 0 ? $"{_book} {_chapter}:{_verse}-{_endVerse}" : $"{_book} {_chapter}:{_verse}";
    }

    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public void SetVerse(int verse)
    {
        _verse = verse;
    }
    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }
}
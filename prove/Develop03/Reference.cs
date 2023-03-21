public class Reference
{
    private string _book;
    private int _chapter;
    private List<string> _verses = new List<string>();

    public Reference (string book, int chapter, List<string> verses)
    {
        _book = book;
        _chapter = chapter;
        _verses = verses;
    }

    public string GetReference()
    {
        string _stringReference;
        int _versesCount = _verses.Count;
        if(_versesCount > 1)
        {
            string endVerse = _verses.Last();
            _stringReference = $"{_book} {_chapter}:{_verses[0]}-{endVerse}";
        } 
        else
        {
            _stringReference = $"{_book} {_chapter}:{_verses[0]}";
        }

        return _stringReference;
    }

}
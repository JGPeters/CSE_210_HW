public class Word
{
    private bool _isHidden;
    private string _word;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void Hide()
    {
        int length = _word.Length;
        string hiddenWord = "";
        for(int i = 1; i<= length; i++)
        {
            hiddenWord = $"{hiddenWord}_";
        }
        _word = hiddenWord;
        _isHidden = true;
    }
    
    public string GetWord()
    {
        return _word;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

}
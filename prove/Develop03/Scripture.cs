public class Scripture
{
    private Reference _reference;
    string _text;
    List<Word> _wordList = new List<Word>();



    public Scripture(Reference reference, string text)
    {
        _text = text;
        _reference = reference;
        string[] _words = GetTextList();
        _wordList = GetWords(_words);
    }

    public void DisplayScripture()
    {
        string _referenceString = _reference.GetReference();
        Console.Clear();
        Console.Write($"{_referenceString} ");
        foreach(Word word in _wordList)
        {
            Console.Write($"{word.GetWord()} ");
        }
    }

    private string[] GetTextList()
    {
      string[] words = _text.Split(); 
      return words; 
    }

    private List<Word> GetWords(string[] text)
    {
        List<Word> wordList = new List<Word>();
        foreach(string word in text)
        {
            wordList.Add(new Word(word));
        }
        return wordList;
    }

    public bool HideWords()
    {
        int _numWords = 0;
        int _numHidden = 0;
        foreach(Word word in _wordList)
        {
            _numWords ++;
            if (word.IsHidden())
            {
                _numHidden ++;
            }
        }
        int _numLeft = _numWords - _numHidden;
        int _numToHide = 3;
        if(_numLeft < 3)
            {
                _numToHide = _numLeft;
            }
        int _numHiddedThisTime = 0;
        foreach(Word word in _wordList)
        {
            if(!word.IsHidden() && _numHiddedThisTime < _numToHide)
            {
                Random rnd = new Random();
                int randInt = rnd.Next(1,4);
                if(randInt == 1)
                {
                    _numHiddedThisTime ++;
                    _numLeft --;
                    word.Hide();

                }
            }
        }
        if(_numLeft == 0)
        {
            return true;
        }  
        else
        {
            return false;
        }
    }

}
class Word
//TODO later for Exceeds: keep punctuation when hiding words
{
    //class variables (aka: Fields): 
    // Ruberic: must all be PRIVATE
    private string _text;
    private bool _isHidden;
    //private string _originText;


    // AllInTitleCase: 1) constructors, 2) methods, 3)properties aka get-set

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //properties: getters and setters
    public string GetDisplayTextWord()
    {
        return Show();
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string Show()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
            //I would have looped through the word, this is much easier. 
        }
        else
        {
            return _text;
        }
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}
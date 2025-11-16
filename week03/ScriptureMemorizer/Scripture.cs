class Scripture
{
    // Ruberic: must all be PRIVATE
    private string _reference;
    private List<Word> _words;


    public Scripture(string scriptureReference, string scriptureText)
    {
        _reference = scriptureReference;

        _words = new List<Word>();
        {
            foreach (string word in scriptureText.Split(' ')) //string bc w is a string not an object
            {
                _words.Add(new Word(word));
            }
        }
    }


    public string GetDisplayTextScripture()
    {
        string display = _reference + " ";

        foreach (Word w in _words)
        {
            display += w.Show() + " ";
        }
        return display; //display.Trim(); if needed
    }


    public int HideRandomWords()
    {
        int remaining = _words.Count(w => !w.IsHidden());
        int numberToHide = Math.Min(3, remaining);
        {
            for (int i = 0; i < numberToHide; i++)
            {
                int index = Random.Shared.Next(0, _words.Count);
                if (_words[index].IsHidden())
                {
                    i--;
                    continue;
                }
                else
                {
                    _words[index].Hide();
                }
            }
            return numberToHide;
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden()) 
            //logic: if ANY word is NOT hidden is easier to code; than if ALL words are hidden
            {
                return false;
            }
        }
        return true;
    }
}
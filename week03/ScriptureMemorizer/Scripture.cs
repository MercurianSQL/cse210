using System.Security.Cryptography;

class Scripture
{
    // Ruberic: must all be PRIVATE
    private Reference _reference;
    private List<Word> _words;


    public Scripture(string scriptureReference, string scriptureText)
    {
        //set specific split points
        int lastSpace = scriptureReference.LastIndexOf(' '); //single quotes!
        string book = scriptureReference.Substring(0, lastSpace);
        string chapVerse = scriptureReference.Substring(lastSpace + 1); 
        //split the splits- chapter from verse
        string[] chapVerseParts = chapVerse.Split(':');
        int chapter = int.Parse(chapVerseParts[0]);
        //verse from multi-verse, if any
        string[] verseParts = chapVerseParts[1].Split('-');//split after index creates an array[]
        int verse = int.Parse(verseParts[0]);
        //shorthand: condition ? valueIfTrue : valueIfFalse;
        string multiverse = verseParts.Length > 1 ? "-" + verseParts[1] : "";

        _reference = new Reference(book, chapter, verse, multiverse);

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
        string display = _reference.GetDisplayTextReference() + "\n";

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
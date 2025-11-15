class Reference
{
    //class variables (aka: Fields): 
    // Ruberic: must all be PRIVATE
    private string _book;
    private int _chapter;
    private int _verse;
    private string _multiVerse;

    //constructor
    public Reference(string book, int chap, int verse, string multiverse = "")
    {
        _book = book;
        _chapter = chap;
        _verse = verse;
        _multiVerse = multiverse;
    }

    //Get-Set
    public string GetDisplayTextReference()
    {
        return $"{_book} {_chapter}:{_verse}{_multiVerse}";
    }

    //methods: no methods
}
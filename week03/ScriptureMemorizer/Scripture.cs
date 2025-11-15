class Scripture
{
    //class variables (aka: Fields): 
    // Ruberic: must all be PRIVATE
    private string _reference;
    private List<Word> _words;


    // AllInTitleCase: 1) constructors, 2) Get-Set, 3) methods 

    //constructor: SETs initial values. NO return, but dont set to void.
    //ex: the car is painted green
    public Scripture(string scriptureReference, string scriptureText)
    {
        _reference = //GetDisplayTextReference();

        _words = new List<Word>();
        //foreach?
    }
    //Get-Set: 
    //get or change the values of PRIVATE Fields
    //returns a value or VOID (usually void)
    //ex: repaint the car; 
    //cannot ask the cust what color, only read the work order
    //Get the green car Set paint color to blue.
    public string GetDisplayTextScripture()
    {
        return $"{_reference} {_words}";
    }

    //methods:
    //ActionVerbs: do things to or with the Fields (drive the car, paint the car)
    //ex: drive the green car into the bay, drive the blue car out of the bay
    HideRandomWords()
    {
        //code to hide random words
    }
    IsCompletelyHidden()
    {
        //code to check if all words are hidden
    }
}
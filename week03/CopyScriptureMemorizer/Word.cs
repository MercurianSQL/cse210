class Word
{
    //class variables (aka: Fields): 
    // Ruberic: must all be PRIVATE
    private string _text;
    private bool _isHidden;


    // AllInTitleCase: 1) constructors, 2) Get-Set, 3) methods 

    //constructor: SETs initial values. NO return, but dont set to void.
    //ex: the car is painted green
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Get-Set: 
    //get or change the values of PRIVATE Fields
    //returns a value or VOID (usually void)
    //ex: repaint the car; 
    //cannot ask the cust what color, only read the work order
    //Get the green car Set paint color to blue.
    public string GetDisplayTextWord()
    {
        return "Word <List>";
    }

    //methods:
    //ActionVerbs: do things to or with the Fields (drive the car, paint the car)
    //ex: drive the green car into the bay, drive the blue car out of the bay
    public void Hide()
    {
            //code to hide the word
    }

    public void Show()
    {
            //code to show the word
    }
    
    public bool IsHidden()
    {
        return _isHidden;
    }
}
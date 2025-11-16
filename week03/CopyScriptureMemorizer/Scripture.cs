class Scripture
//Hold the object Scripture 
//and list of word objects, 
//coordinate hiding words by selecting random unhidden words 
//and it will compose the final text string for display
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
        _reference = scriptureReference;

        _words = new List<Word>();
        {
            foreach (string word in scriptureText.Split(' ')) //string bc w is a string not an object
            {
                _words.Add(new Word(word));
            }
        }
    }
    //Get-Set: 
    //get or change the values of PRIVATE Fields
    //returns a value or VOID (usually void)
    //ex: repaint the car; 
    //cannot ask the cust what color, only read the work order
    //Get the green car Set paint color to blue.
    public string GetDisplayTextScripture()
    {
        return $"{_reference} \n {_words}";
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
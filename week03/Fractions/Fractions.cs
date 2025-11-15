public class Fractions


{
    //attributes
    private int _top = 1;
    private int _bottom = 1;


    //constructors: 
    // create and initialize an object. 
    // SETs initial values. NO return.
    //ex: paint the car
    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fractions(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    //getters and setters: 
    //get or change the values of PRIVATE Attribute fields
    //returns a value or VOID (usually void)
    //ex: repaint the car; 
    //cannot ask the cust what color, only read the work order
    //Get the green car Set paint color to blue.
    public int GetTop() //Not in Sample Code!!! Then why in instructions?
    {
        return _top;
    }
    public int GetBottom() //Not in Sample Code!!! Then why in instructions?
    {
        return _bottom;
    }

    public void SetTop(int value) //Not in Sample Code!!! Then why in instructions?
    {
        _top = value;
    }
    public void SetBottom(int value) //Not in Sample Code!!! Then why in instructions?
    {
        _bottom = value;
    }

    //methods
    // ActionVerbs: do things to or with the attributes
    //ex: drive the green car into the bay, drive the blue car out of the bay
    public string GetFractionString() //can be called by main
    {
        GetTop();
        GetBottom();
        {
            return $"{_top}/{_bottom}";
        }
        /*if (_bottom == 1)
        {
            return $"{_top}";
        }
        else if (_top < _bottom)
        {
            return $"{_top}/{_bottom}";
        }
        else
        {
            return $"({_top / _bottom} {_top % _bottom}/{_bottom})";
        }*/
    }
    public double GetDecimalValue() //can be called by main
    {
        GetTop();
        GetBottom();
        return (double)_top / _bottom;
    }
}
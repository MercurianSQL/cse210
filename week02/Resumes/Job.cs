//Bullet Example
//Class: Job (object in TitleCase)

//Attributes: (attribute in _camelCase)
//* _company : string
//* _jobTitle : string
// _startYear : int
// _endYear : int

//Behaviors: (function in TitleCase())
//* Display() : void

// Class
public class Job
{
    // Attributes (_memberVariables)
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    //Behaviors (MemberFunction)
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
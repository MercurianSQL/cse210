//Bullet Example
//Class: Resume (object in TitleCase)

//Attributes: (attribute in _camelCase)
//* _name : string
//* _jobs : List<Job>


//Behaviors: (function in TitleCase())
//* Display() : void

// Class
public class Resume
{
    // Attributes (_memberVariable)
    public string _name; //why did CGPT have me remove (= "")
    public List<Job> _job = new List<Job>();

    //Behaviors
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in _job)
        {
            job.DisplayJobDetails();
        }
    }
}
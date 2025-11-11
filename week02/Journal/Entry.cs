public class Entry // Represents a single journal entry.
{
    public DateTime _dateTime;
    public string _journalPrompt;
    public string _userResponse;

    public void Display()
    {
        Console.WriteLine(_dateTime);
        Console.WriteLine(_journalPrompt);
        Console.WriteLine(_userResponse);
    }
}
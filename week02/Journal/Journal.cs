public class Journal
// Stores a list of journal entries: 
{
    public List<Entry> _userEntries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _userEntries.Add(newEntry); //void doesnt mean empty
    }
    public void DisplayAll()
    {
        if (_userEntries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.");
            Console.WriteLine("Please load a saved journal or start new journal.");
        }
        else
        {
            foreach (Entry newEntry in _userEntries)
            {
                newEntry.Display();
            }
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry newEntry in _userEntries) //not ._userEntries. no dot
            {
                newEntry.Display();
                {
                    outputFile.WriteLine(newEntry._dateTime); //do add ._here uses dot
                    outputFile.WriteLine(newEntry._journalPrompt);
                    outputFile.WriteLine(newEntry._userResponse);
                    outputFile.WriteLine();
                }
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        // no return
    }
}
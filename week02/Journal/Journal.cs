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
            foreach (Entry entry in _userEntries)
            {
                entry.Display();
            }
        }
    }
    public void SaveToFile(string file)
    {
        // no return
    }
    public void LoadFromFile(string file)
    {
        // no return
    }
}
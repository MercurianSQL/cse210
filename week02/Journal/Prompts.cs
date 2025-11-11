public class Prompts // Supplies random prompts whenever needed.
// the benefit of abstraction is that you could add other prompt methods
// later on and not have to change the way the rest of the program works
{
    public List<string> _prompts;

    private Random _random;

    public Prompts()
    {
        _prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "List three things I am grateful for, two things I am blessed with, and one blessing I want for myself or someone else."
        };

        _random = new Random();
    }

    public string DisplayRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
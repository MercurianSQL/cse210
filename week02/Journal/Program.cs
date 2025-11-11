using System;

class Program  // only containing a few static methods
{
    static string letter = "";
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry AddEntry = new Entry();


        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select an action: ");
        Console.WriteLine("1. Write a new journal entry");
        Console.WriteLine("2. Display previous journal entries");
        Console.WriteLine("3. Load journal entries from a file");
        Console.WriteLine("4. Save journal entries to a file");
        Console.WriteLine("5. Quit");
        Console.Write("Please enter the number of your action: ");
        string userAction = Console.ReadLine();
        int actionInt = int.Parse(userAction);


        if (actionInt == 1)
        {
            Prompts prompts = new Prompts();

            string prompt = prompts.DisplayRandomPrompt();

            Console.WriteLine(prompt);
            Console.Write("> ");
            Entry entry = new Entry();
            entry._userResponse = Console.ReadLine();

            AddEntry._dateTime = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            AddEntry._journalPrompt = prompt;
        }

        else if (actionInt == 2)
        {
            letter = "B";
        }

        else if (actionInt == 3)
        {
            letter = "C";
        }

        else if (actionInt == 4)
        {
            letter = "D";
        }

        else if (actionInt == 5)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

    Console.WriteLine(letter);

    }
}
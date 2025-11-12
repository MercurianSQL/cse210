using System;

class Program  // only containing a few static methods
{
    static Journal myJournal = new Journal();

    static string letter = "";
    static void Main(string[] args)
    {
        Entry AddEntry = new Entry();
        int actionInt = 0;
        Console.WriteLine("Welcome to the Journal Program!");
        while (actionInt != 5)
        {
            Console.WriteLine("Please select an action: ");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display previous journal entries");
            Console.WriteLine("3. Load journal entries from a file");
            Console.WriteLine("4. Save journal entries to a file");
            Console.WriteLine("5. Quit");
            Console.Write("Please enter the number of your action: ");
            string userAction = Console.ReadLine();
            actionInt = int.Parse(userAction);


            if (actionInt == 1) //Write a new journal entry
            {
                Prompts prompts = new Prompts();
                string prompt = prompts.DisplayRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");

                Entry newEntry = new Entry(); // note all these are newEntry._  NOT  AddEntry._
                newEntry._dateTime = DateTime.Now;
                newEntry._journalPrompt = prompt;
                newEntry._userResponse = Console.ReadLine();

                myJournal.AddEntry(newEntry);

                //use myJournal.AddEntry(newEntry); --direct field access
                //instead of theJournal._entries.Add(anEntry); --vs a methoid call


            }

            else if (actionInt == 2)//Display previous journal entries
            {
                myJournal.DisplayAll();
            }

            else if (actionInt == 3)//Load journal entries from a file
            {
                letter = "C";
            }

            else if (actionInt == 4)//Save journal entries to a file
            {
                Console.WriteLine($"DEBUG: actionInt is {actionInt}"); //PASSED
                Console.WriteLine("Enter a filename for your journal: ");
                string filename = Console.ReadLine();
                filename += ".txt";
                myJournal.SaveToFile(filename);
                Console.WriteLine("Journal saved to " + filename);
            }

            else if (actionInt == 5)//Quit
            {
                Console.WriteLine("See you tomorrow!");
            }

            else
            {
                Console.WriteLine("That number is not a valid action. Please choose a number from 1 to 5.");
                //add a string exception later
            }

            Console.WriteLine(letter);

        }
    }
}
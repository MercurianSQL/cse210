using System;

class Program

{
    static void Main(string[] args)
    {
        Scripture mytext = new Scripture("2 Nephi 25:26\n", "And we talk of Christ, we rejoice in Christ, we preach of Christ,\n we prophesy of Christ, and we write according to our prophecies,\n that our children may know to what source they may look for a remission of their sins.\n");
        Console.WriteLine(mytext.GetDisplayTextScripture());
        bool quit = false;

        while (quit == false)
        {
            Console.WriteLine("Press Enter to continue or X to quit: ");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "x")
            {
                quit = true;
            }
            else if (mytext.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations. All words are hidden. Goodbye!");
                quit = true;
            }
            else
            {
                mytext.HideRandomWords();
                Console.WriteLine(mytext.GetDisplayTextScripture());
            }
        }
    }
}
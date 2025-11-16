using System;
//Exceeds: Code handles books that include a space such as "St. John" or "2 Nephi".
class Program

{
    static void Main(string[] args)
    {
        Scripture mytext = new Scripture("2 Nephi 25:26", "And we talk of Christ, we rejoice in Christ, we preach of Christ,\n we prophesy of Christ, and we write according to our prophecies,\n that our children may know to what source they may look for a remission of their sins.\n");
        Console.WriteLine(mytext.GetDisplayTextScripture());
        bool quit = false;
        //TESTED with "2 Nephi 25:26-27", PASS

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
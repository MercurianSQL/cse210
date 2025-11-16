using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        //test Reference class
        Reference verse = new Reference("John", 3, 16);
        Console.WriteLine(verse.GetDisplayTextReference());

        //test Scripture class
        Scripture text = new Scripture("John 3:16", "For God so loved the world");
        Console.WriteLine(text.GetDisplayTextScripture());

        //test Word class
        Word game = new Word(from list);
        Console.WriteLine(game.GetDisplayTextWord());
    }
}
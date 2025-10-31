using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        Console.WriteLine($"Hello, {userName}.");
        int userNumber = PromptUserNumber();
        int numberSquared = SquaredNumber(userNumber);
        Console.WriteLine($"{userName}, your number, {userNumber}, is the square root of {numberSquared}.");
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {//Asks for and returns the user's name (as a string)
        Console.Write("What can I call you? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {//Asks for and returns the user number (as an integer)
        Console.Write("Choose a number, any number. ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquaredNumber(int userNumber)
    {//Accepts an integer as a parameter and returns that number squared (as an integer)
        int numberSquared = (userNumber * userNumber);
        return numberSquared;
    }
    //DisplayResult - Accepts the user's name and the squared number and displays them.

}
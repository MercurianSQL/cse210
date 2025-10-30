using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello user. What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int gp = int.Parse(userInput);
        string letter;

        if (gp >= 90)
        {
            letter = "A";
        }

        else if (gp >= 80)
        {
            letter = "B";
        }

        else if (gp >= 70)
        {
            letter = "C";
        }

        else if (gp >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        int lastDigit = gp % 10;
        string mark = "";

        if (lastDigit >= 7)
        {
            mark = "+";
        }

        else if (lastDigit < 3)
        {
            mark = "-";
        }

        else
        {
            mark = "";
        }

        if (letter == "A" && mark == "+")
        {
            mark = "";
        }

        if (letter == "F" && mark == "+")
        {
            mark = "";
        }
        else if (letter == "F" && mark == "-")
        {
            mark = "";
        }

        Console.WriteLine($"Your grade is {letter}{mark}.");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations, you passed the course.");
        }
        else
        {
            Console.WriteLine("You almost have a grasp on the material. You have it in you, try again.");
        }
    }

}

using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 101); //For random # between 1-100, code has to be 1-101

        /*Console.Write("What is the Magic Number? ");
        string userInput = Console.ReadLine();

        int mNumber = int.Parse(userInput);
        */
        string guessAgain = "yes";

        do
        {
            Console.Write("What is the Magic Number? ");
            string userGuess = Console.ReadLine();  // here is a shortcut:  guess = int.Parse(Console.ReadLine());

            int guess = int.Parse(userGuess);

            if (guess == mNumber)
            {
                Console.Write("You guessed the Magic Number!");
                guessAgain = "no";
            }
            else if (guess > mNumber)
            {
                Console.WriteLine("Guess a lower number.");
            }
            else if (guess < mNumber)
            {
                Console.WriteLine("Guess a higher number.");
            }
            else
            {
                if (guess > mNumber || guess < mNumber)
                {
                    guessAgain = "yes";
                }
            }

        } while (guessAgain == "yes");
    }
}
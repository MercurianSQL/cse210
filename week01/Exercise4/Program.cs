using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); //create the list

        int number = -1;
        //create the variables, Stop when 0 entered
        int sum = 0;
        int count = 0;
        float average = 0;
        int max = 0;

        while (number != 0) //dont forget the parenthesis
        {
            Console.Write("Please enter a number or 0 to stop: ");
            //Ask the user for a series of numbers
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            //number was already declared an int so 
            // int.parse wont have a prob w/change str to int

            if (number != 0) //need both while and if !=0 statements
            {
                numbers.Add(number); // append numbers to a list.
            }

        }

        foreach (int n in numbers)
        { //is there another way to make this work?
        }
        Console.WriteLine($"Numbers List [" + string.Join(", ", numbers) + "]");


        //Compute the sum, 
        foreach (int i in numbers)
        {
            sum += i;
        }
        Console.WriteLine($"The sum of your list is {sum}");

        //Compute the average 
        count = numbers.Count;
        Console.WriteLine($"There are {count} numbers in your list.");
        average = (float)sum / count; //here, count could have been numbers.Count, and skip the extra variable
        Console.WriteLine($"The average of the numbers in your list is {average}.");

        //Find the maximum (largest number)
        foreach (int i in numbers)
        {
            if (i >= max)
            {
                max = i;
            }
        }
        Console.WriteLine($"The largest number on your list is {max}.");
    }
}
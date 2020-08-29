/* Name: Enrique Tejeda
 * Date: 8-28-2020
 * File: Program.cs
 * Description: Program is a game where the user will have to guess a number from 0-100. Program will output how many attempts
 *              were made until the answer is reached.
 */


using System;

namespace Git_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to guess the number!\nEnter the lower bound:");
            int lowerBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the upper bound:");
            int upperBound = Convert.ToInt32(Console.ReadLine());
            int answer = 0;
            Random random = new Random();
            answer = random.Next(lowerBound, upperBound);
            Console.WriteLine($"\nGuess the number between {lowerBound} and {upperBound}!");
            int guess = -1;
            try
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > answer)
                {
                    Console.WriteLine("\nGuessed too high!");
                }
                else if (guess < answer)
                {
                    Console.WriteLine("\nGuessed too low!");
                }
            }
            catch
            {
                Console.WriteLine($"Error, try a number between {lowerBound}-{upperBound}.");
            }
            int attempts = 1;
            while (guess != answer)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess > answer)
                    {
                        Console.WriteLine("\nGuessed too high!");
                    }
                    else if (guess < answer)
                    {
                        Console.WriteLine("\nGuessed too low!");
                    }
                }
                catch
                {
                    Console.WriteLine($"Error, try a number between {lowerBound}-{upperBound}.");
                }
                attempts++;
            }
            Console.WriteLine($"It took you {attempts} tries until you guessed {answer}!");
        }
    }
}

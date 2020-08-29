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
            Console.WriteLine("Welcome to guess the number (0-100)!");
            int answer = 0;
            Random random = new Random();
            answer = random.Next(0, 100);
            Console.WriteLine("Guess the number between 0 and 100!");
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
                Console.WriteLine("Error, try a number between 0-100.");
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
                    Console.WriteLine("Error, try a number between 0-100.");
                }
                attempts++;
            }
            Console.WriteLine($"It took you {attempts} tries until you guessed {answer}!");
        }
    }
}

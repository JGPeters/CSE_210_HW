using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        int guess = 101;
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if(guess == number)
            {
                Console.WriteLine("You guessed the number!");
            }
            else if(guess < number)
            {
                Console.WriteLine("Your guess is too low, try again.");
            }
            else
            {
                Console.WriteLine("Your guess is too high, try again.");
            }

        } while(guess != number);
    }
}
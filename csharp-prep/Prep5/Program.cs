using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

         static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int sqr = number * number;
            return sqr;
        }

        static void DisplayResult(string name, int sqr)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {sqr}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqr = SquareNumber(number);
        DisplayResult(name, sqr);
    }
}
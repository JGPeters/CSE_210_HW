using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade percentage did you recieve? ");
        int grade = int.Parse(Console.ReadLine());
        if(grade >= 90)
        {
            Console.WriteLine("You got an A!");
            Console.WriteLine("Congrats, you pass!");
        }
        else if(grade >= 80)
        {
            Console.WriteLine("You got a B!");
            Console.WriteLine("Congrats, you pass!");
        }
        else if(grade >= 70)
        {
            Console.WriteLine("You got a C!");
            Console.WriteLine("Congrats, you pass!");
        }
        else if(grade >= 60)
        {
            Console.WriteLine("You got a D");
            Console.WriteLine("You didn't pass this time but next time you can do it! I beleive in you!");
        }
        else
        {
            Console.WriteLine("You got an F");
            Console.WriteLine("You didn't pass this time but next time you can do it! I beleive in you!");
        }
    }
}
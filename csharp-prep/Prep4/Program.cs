using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 0;
        do 
        {
            Console.Write("Add a number, enter 0 to stop: ");
            number = int.Parse(Console.ReadLine());
            if(number != 0)
            {
                numbers.Add(number);
            }
        }while(number != 0);
        
        int length = numbers.Count;
        int highest = 0;
        int sum = 0;
        foreach (int integer in numbers)
        {
            sum = sum + integer;
            if(integer > highest)
            {
                highest = integer;
            }

        }
        int average = sum / length;
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The highest number is {highest}");

    }
}
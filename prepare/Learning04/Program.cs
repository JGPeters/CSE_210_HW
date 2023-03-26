using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Jacob", "Computer Science", "4.1", "1-24");
        string mathNameTopic = mathAssignment.GetSummary();
        string mathHomework = mathAssignment.GetHomeworkList();
        Console.WriteLine(mathNameTopic);
        Console.WriteLine(mathHomework);

        WritingAssignment writingAssignment = new WritingAssignment("Jacob", "European History", "The Causes of War");
        Console.Write(writingAssignment.GetWritingInformation());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "BUYI";
        job1._startYear = 2020;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Computer Engineer";
        job2._company = "BUYH";
        job2._startYear = 2021;
        job2._endYear = 2026;

   
        Resume resume = new Resume();
        resume._name = "Jacob";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

    }
}
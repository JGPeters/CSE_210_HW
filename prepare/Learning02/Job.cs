public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public void Display()
    {
        Console.WriteLine($"This person worked as a {_jobTitle} for {_company} from {_startYear} to {_endYear}.");
    }
}
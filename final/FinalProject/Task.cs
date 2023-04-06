public class Task
{

    private string _taskName;
    private string _description;
    private DateOnly _dueDate;
    private bool _complete;

    public Task(string name, string description, DateOnly dueDate)
    {

        _taskName = name;
        _description = description;
        _dueDate = dueDate;
        _complete = false;
    }

    public string GetName()
    {
        return _taskName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public DateOnly GetDueDate()
    {
        return _dueDate;
    }
    public bool GetStatus()
    {
        return _complete;
    }
    public void Complete()
    {
        _complete = true;
    }

    public void UnComplete()
    {
        _complete = false;
    }

    public virtual void DisplayTask()
    {
        Console.WriteLine($"{_taskName}\n{_description}\n{_dueDate}\nComplete: {_complete}");
    }
}
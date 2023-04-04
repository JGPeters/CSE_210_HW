public class Task
{
    private int _taskID;
    private string _taskName;
    private string _description;
    private DateOnly _dueDate;
    private bool _complete;

    public Task(int ID, string name, string description, DateOnly dueDate)
    {
        _taskID = ID;
        _taskName = name;
        _description = description;
        _dueDate = dueDate;
        _complete = false;
    }

    public int GetID()
    {
        return _taskID;
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

    public virtual void DisplayTask()
    {
        Console.WriteLine($"{_taskName}\n{_description}\n{_dueDate}\nComplete: {_complete}");
    }
}
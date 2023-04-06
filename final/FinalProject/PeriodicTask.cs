public class PeriodicTask : Task
{
    private string _period;
    public PeriodicTask(string name, string description, DateOnly dueDate, string period) :base(name, description, dueDate)
    {
        _period = period;
    }

    public override void DisplayTask()
    {
        
    }

}
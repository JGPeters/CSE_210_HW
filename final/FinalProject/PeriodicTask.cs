public class PeriodicTask : Task
{
    private string _period;
    public PeriodicTask(int ID, string name, string description, DateOnly dueDate, string period) :base(ID, name, description, dueDate)
    {
        _period = period;
    }

    public override void DisplayTask()
    {
        
    }

}
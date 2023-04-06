public class TaskList
{
    List<Task> _taskList = new List<Task>();

    
    public bool ValidateTask(Task task)
    {
        if(_taskList.Contains(task))
        {
            return true;
        }
        else
        {
            return false;
        }
       
    }
    public void AddTask(Task task)
    {
        _taskList.Add(task);
    }
    public void RemoveTask(Task task)
    {
        _taskList.Remove(task);
    }
    public void UpdateStatus(Task task)
    {
        if(task.GetStatus())
        {
            task.UnComplete();
        }
        else
        {
            task.Complete();
        }
    }
}
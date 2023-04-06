public class TaskManager
{
  public void DisplayMenu()
  {
    TaskConsoleUI UI = new TaskConsoleUI();
    FileHandler file = new FileHandler();
    string choice = UI.DisplayMenu();
    switch (choice)
    {
        case "save":
            file.Save();
            break;
        
        case "load":
            file.Load();
            break;
        
        case "add":
            break;
        
        case "delete":
            break;

        case "complete":
            break;
        
        case "dueToday":
            break;

        case "dueTommorow":
            break;

        case "dueWeek":
            break;

        case "quit":
            break;
    }
  }  
  public void AddTask(TaskList list, Task task)
  {

    if(TaskAdded(list, task) == false)
    {
        
    }
  }

  private bool TaskAdded(TaskList list, Task task)
  {
    if(list.ValidateTask(task))
    {
        return true;
    }
    else
    {
        return false;
    }
  }

  private Task AddTaskUI()
  {
    Console.Write("What kind of task would you like to add?\n1. Simple\n2. Periodic\n> ");
    string choice = Console.ReadLine();
    Console.Write("What is the name of the task?\n> ");
    string name = Console.ReadLine();
    Console.Write("What is the description of the task?\n> ");
    string description = Console.ReadLine();
    if(choice == "1")
    {
        Console.Write("When is the task due? (MM/DD/YYYY)");
        string monthDayYear = Console.ReadLine();
        string[] split = monthDayYear.Split("/");
        int month = int.Parse(split[0]);
        int day = int.Parse(split[1]);
        int year = int.Parse(split[2]);
        DateOnly dueDate = new DateOnly(year, month, day);
        SimpleTask task = new SimpleTask(name, description, dueDate);
        return task;
    }
    else
    {
        string period;
        Console.Write("What period will you use?\n1. Weekly\n2. Monthly\n> ");
        string periodChoice = Console.ReadLine();
        if(periodChoice == "1")
        {
            period = "Weekly";
        }
        else
        {
            period = "Monthly";
        }
        Console.Write("When is the first due date? (MM/DD/YYYY)");
        string monthDayYear = Console.ReadLine();
        string[] split = monthDayYear.Split("/");
        int month = int.Parse(split[0]);
        int day = int.Parse(split[1]);
        int year = int.Parse(split[2]);
        DateOnly dueDate = new DateOnly(year, month, day);
        PeriodicTask task = new PeriodicTask(name, description, dueDate, period);
        return task;
    }
    
  }

}
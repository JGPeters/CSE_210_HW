public class TaskManager
{
  public void DisplayMenu()
  {
    string choice;
    do
    {
        FileHandler file = new FileHandler();
        TaskConsoleUI UI = new TaskConsoleUI();
        Console.Clear();
        Console.Write("What would you like to do?\n1. Go to Tasks\n2. Save Tasks\n3. Load Tasks\n4. Quit\n> ");
        choice = Console.ReadLine();
        if(choice == "1")
        {
            UI.DisplayMenu();
        }
        else if(choice == "2")
        {
            file.Save();
        }
        else if(choice == "3")
        {
            file.Load();
        }

    }while(choice != "4");

  }  
  public void UpdateTaskList()
  {

  }
}
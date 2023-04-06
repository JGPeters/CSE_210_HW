public class TaskConsoleUI
{
    public string DisplayMenu()
    {
        string choice;
        do{
        Console.Clear();
        Console.Write("What would you like to do?\n1. Go to Tasks\n2. Save Tasks\n3. Load Tasks\n4. Quit\n> ");
        choice = Console.ReadLine();
        if(choice == "1")
        {
            return TaskMenu();
        }
        else if(choice == "2")
        {
            return "save";
        }
        else if(choice == "3")
        {
            return "load";
        }

    }while(choice != "4");
    return "quit";
    }

    private string TaskMenu()
    {
        string choice;
        do{
        Console.Clear();
        Console.Write("What would you like to do?\n1. Add Task\n2. Delete Task\n3. Complete Task\n4. Generate Task Report\n5. Quit\n> ");
        choice = Console.ReadLine();
        if(choice == "1")
        {
            return "add";
        }
        else if(choice == "2")
        {
            return "delete";
        }
        else if(choice == "3")
        {
            return "complete";
        }
        else if(choice == "4")
        {
            return WhichReport();
        }
        }while(choice != "5");
        return "quit";


    }

    private string WhichReport()
    {
        string choice;
        do{
            Console.Clear();
            Console.Write("Which kind of report do you want?\n1. Due Today\n2. Due Tommorow\n3. Due This Week\n4. Quit\n> ");
            choice = Console.ReadLine();
            if(choice == "1")
            {
                return "dueToday";
            }
            else if(choice == "2")
            {
                return "dueTommorow";
            }
            else if(choice == "3")
            {
                return "dueWeek";
            }
        }while(choice != "4");
        return "quit";
    }
}
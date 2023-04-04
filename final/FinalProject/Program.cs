using System;

class Program
{
    static void Main(string[] args)
    {
        TaskList taskList = new TaskList();
        TaskManager manager = new TaskManager();
        TaskReporter reporter = new TaskReporter();
        manager.DisplayMenu();
    }
}
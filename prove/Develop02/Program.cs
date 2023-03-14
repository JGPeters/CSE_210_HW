using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string GetChoice()
        {
            Console.Write("What would you like to do?\n1.Add entry\n2.Display entries\n3.Save\n4.Load\n5.Quit\n> ");
            string choice = Console.ReadLine();
            return choice;
        }
        void Menu()
        {
            string choice = "0";
            do{
                choice = GetChoice();
                if(choice == "1")
                {
                    journal.AddEntry();
                }
                else if(choice == "2")
                {
                    journal.Display();
                }
                else if(choice == "3")
                {
                    journal.Save();
                }
                else if(choice == "4")
                {
                    journal.Load();
                }
                else if(choice != "5")
                {
                    Console.WriteLine("Invalid choice, try again.");
                }
            }while(choice != "5"); 
        }
        Menu();
    }
}
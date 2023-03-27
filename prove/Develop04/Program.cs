using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breatheActivity = new BreathingActivity("Breathing");
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection");
        ListingActivity listingActivity = new ListingActivity("Listing");

        void Menu()
        {
           string choice;
           do{
           Console.Clear();
           Console.Write("Menu Options:\n   1. Start breathing activity\n   2. Start reflecting activity\n   3. Start listing activity\n   4. Quit\n> "); 
           choice = Console.ReadLine();
           if(choice == "1")
           {
            breatheActivity.DisplayIntro();
            breatheActivity.DoBreath();
            breatheActivity.DisplayOutro();
           }
           else if(choice == "2")
           {
            reflectionActivity.DisplayIntro();
            reflectionActivity.DoReflect();
            reflectionActivity.DisplayOutro();
           }
           else if(choice == "3")
           {
            listingActivity.DisplayIntro();
            listingActivity.DoListing();
            listingActivity.DisplayOutro();
           }
           }while(choice != "4");
        }

        
        Menu();
        
        //To show creativity I made it so you cant get a repaeted prompt or question in the reflection and listing activities until you have gone through them all.
    }
}
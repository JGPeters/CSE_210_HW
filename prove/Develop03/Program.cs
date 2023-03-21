using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> list1 = new List<string>{"16"};
        Reference reference1 = new Reference("John", 3, list1);
        Scripture scripture1 = new Scripture(reference1, "For God so loved the world that he gave his one and only Son, that whoever believes in him should not perish but have eternal life.");
        
        List<string> list2 = new List<string>{"5", "6"};
        Reference reference2 = new Reference("Proverbs", 3, list2);
        Scripture scripture2 = new Scripture(reference2, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        List<string> list3 = new List<string>{"7"};
        Reference reference3 = new Reference("Nephi", 3, list3);
        Scripture scripture3 = new Scripture(reference3, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        void Menu()
        {
            Console.Write("Which scripture would you like to memorize?\n1. John 3:16\n2. Proverbs3:5-6\n3. Nephi 3:7\n> ");
            string choice = Console.ReadLine();
            Scripture scripture;
            if(choice == "1")
            {
                scripture = scripture1;
            }
            else if(choice == "2")
            {
                scripture = scripture2;
            }
            else
            {
                scripture = scripture3;
            }
            bool allHidden = false;
            do
            {
                scripture.DisplayScripture();
                string quit = Console.ReadLine();
                if(quit =="quit" || quit == "Quit")
                {
                    allHidden = true;
                }
                else
                {
                    allHidden = scripture.HideWords();
                }
            }while(!allHidden);
            scripture.DisplayScripture();

        }

        Menu();
        

    }   

//To show creativity I let the user choose between 3 scriptures instead of 1

}
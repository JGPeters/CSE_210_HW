using System.IO;
public class Journal
{
   public List<Entry> _entries = new List<Entry>(); 

   public void Display()
   {
    foreach (Entry entry in _entries)
    {
        entry.Display();
    }
   }

    private string GetResponse(string prompt)
    {
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        return response;

    }

    private string GetFileName(string type)
    {   
        if (type == "save")
        {
            Console.Write("Name your file: ");
        }
        else
        {
            Console.Write("Load what file?: ");
        }
        
        string fileName = Console.ReadLine();
        return fileName;
    }
   public void AddEntry()
   {
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();
    PromtGen promptGen = new PromtGen();
    string prompt = promptGen.GetPrompt();
    string response = GetResponse(prompt);

    Entry entry = new Entry(dateText, prompt, response);
    _entries.Add(entry);
   }

   public void Save()
   {
    string fileName = GetFileName("save");

    using ( StreamWriter saveFile = new StreamWriter(fileName))
    {
        foreach(Entry entry in _entries)
        {
            string line = entry.GetLine();
            saveFile.WriteLine(line);           
        }
    }
   }

   public void Load()
   {
    _entries.Clear();
    string fileName = GetFileName("load");
    string[] lines = System.IO.File.ReadAllLines(fileName);
    foreach (string line in lines)
    {
        string[] parts = line.Split(",");
        string date = parts[0];
        string prompt = parts[1];
        string response = parts[2];
        Entry entry = new Entry(date, prompt, response);
        _entries.Add(entry);
    }
   }
}
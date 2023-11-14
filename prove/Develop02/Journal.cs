public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);

        Console.WriteLine("Entry added. " + entry._date);
    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string filename)
    {

    }

    public void LoadFromFile(string filename)
    {

    }
}
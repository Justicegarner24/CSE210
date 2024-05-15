using System;

public class JournalEntry
{
    public string _entryNumber = "";
    public string _dateTime = "";
    public string _journalPrompt = "";
    public string _journalEntry = "";
    public string _journalFile = "";

    public JournalEntry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_entryNumber} - {_dateTime}");
        Console.WriteLine($"{_journalPrompt}");
        Console.WriteLine($"{_journalEntry}");
    }
}


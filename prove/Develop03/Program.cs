
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("James", "1", "5");
        Scripture scripture = new Scripture(scriptureReference, "5 If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.");
        ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(scripture);

        string userInput = "";

        while (userInput != "quit" && scriptureMemorizer.hasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
            Console.WriteLine();
            userInput = Console.ReadLine();
            scriptureMemorizer.removeWordsFromText();
        }
        Console.Clear();
        Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriptureMemorizer.toString()));
        Console.WriteLine();
        Console.WriteLine("Good job!");
    }
}
using System;
using static System.Console;

public class Letter
{
    public string Name { get; set; }
    public string Date { get; set; }

    public Letter()
    {
        Name = "";
        Date = "";
    }

    public override string ToString()
    {
        return GetType().Name + " " + Name + " " + Date;
    }
}

public class CertifiedLetter : Letter
{
    public string TrackingNumber { get; set; }

    public CertifiedLetter()
    {
        TrackingNumber = "";
    }

    public override string ToString()
    {
        return GetType().Name + " " + Name + " " + Date + " " + TrackingNumber;
    }
}

public class LetterDemo
{
    static void Main()
    {
        Letter letter = new Letter();
        CertifiedLetter certified = new CertifiedLetter();
        WriteLine(letter.ToString());
        WriteLine(certified.ToString());
    }
}
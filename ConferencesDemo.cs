using System;
using static System.Console;


class Conference : IComparable<Conference>
{
    private string group;
    private string date;
    private int attendees;

    public Conference()
    {
        group = "";
        date = "";
        attendees = 0;
    }

    public string Group
    {
        get { return group; }
        set { group = value; }
    }

    public string Date
    {
        get { return date; }
        set { date = value; }
    }

    public int Attendees
    {
        get { return attendees; }
        set { attendees = value; }
    }

    public int CompareTo(Conference alter)
    {
        if (alter == null) return 1;
        return this.attendees.CompareTo(alter.attendees);
    }
}

class ConferencesDemo
{
    static void Main(string[] args)
    {
        Conference[] ConferenceArr = new Conference[5];

        for (int i = 0; i < ConferenceArr.Length; i++)
        {
            ConferenceArr[i] = new Conference();

            Write("Enter conference group name >> ");
            string group = ReadLine();
            ConferenceArr[i].Group = group;

            Write("Enter conference starting date >> ");
            string date = ReadLine();
            ConferenceArr[i].Date = date;

            Write("Enter attendees >> ");
            string attendeesInput = ReadLine();
            ConferenceArr[i].Attendees = Convert.ToInt32(attendeesInput);
        }

        WriteLine();
        Array.Sort(ConferenceArr);

        foreach (Conference conf in ConferenceArr)
        {
            WriteLine($"{conf.Group} Conference starts on {conf.Date} and has {conf.Attendees} attendees");
        }
    }
}

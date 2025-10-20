using System;
using static System.Console;
using System.Globalization;

public class Job
{
    public int JobNumber { get; set; }
    public string Customer { get; set; }
    public string Description { get; set; }

    private double hours;
    private double price;

    public double Hours
    {
        get { return hours; }
        set
        {
            hours = value;
            price = hours * 45.00;
        }
    }

    public double Price
    {
        get { return price; }
    }

    public Job(int jobNumber, string customer, string description, double hours)
    {
        JobNumber = jobNumber;
        Customer = customer;
        Description = description;
        Hours = hours;
    }

    public override bool Equals(object obj)
    {
        if (obj is Job)
        {
            Job other = (Job)obj;
            return this.JobNumber == other.JobNumber;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return JobNumber;
    }

    public override string ToString()
    {
        return $"Job {JobNumber} {Customer} {Description} {Hours} hours @$45.00 per hour. Total price is {Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
    }
}

public class JobDemo
{
    public static void Main()
    {
        Job j = new Job(0, "", "", 0);
    }
    
}

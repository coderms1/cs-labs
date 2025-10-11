using System;
using System.Globalization;
using static System.Console;

class SalesTransaction
{
    public string Name { get; set; }
    private double salesAmount;
    private double commission;
    private readonly double RATE;

    public double SalesAmount
    {
        get { return salesAmount; }
        set
        {
            salesAmount = value;
            commission = salesAmount * RATE;
        }
    }

    public double Commission
    {
        get { return commission; }
    }

    public double getRate()
    {
        return RATE;
    }

    public SalesTransaction(string name, double salesAmount, double rate)
    {
        Name = name;
        RATE = rate;
        SalesAmount = salesAmount;
    }

    public SalesTransaction(string name, double salesAmount) 
        : this(name, salesAmount, 0) { }

    public SalesTransaction(string name) 
        : this(name, 0, 0) { }

    public static SalesTransaction operator +(SalesTransaction sale1, SalesTransaction sale2)
    {
        double totalSales = sale1.salesAmount + sale2.salesAmount;
        return new SalesTransaction("Total", totalSales);
    }
}

class SalesTransactionDemo
{
    static void Main(string[] args)
    {
        SalesTransaction Sale1 = new SalesTransaction("Johnny", 2000, 0.20);
        SalesTransaction Sale2 = new SalesTransaction("Frank", 4000);
        SalesTransaction Sale3 = new SalesTransaction("HQ");
        SalesTransaction total = Sale1 + Sale2 + Sale3;

        Display(Sale1);
        Display(Sale2);
        Display(Sale3);
        DisplayTotal(total);
    }

    static void Display(SalesTransaction txn)
    {
        WriteLine("{0} had sales totaling {1}", 
            txn.Name, 
            txn.SalesAmount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("Commission rate: {0}", txn.getRate());
        WriteLine("Commission value: {0}\n", 
            txn.Commission.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }

    static void DisplayTotal(SalesTransaction txn)
    {
        WriteLine("Total sales: {0}", 
            txn.SalesAmount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}
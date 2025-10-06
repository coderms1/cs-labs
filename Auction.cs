using System;
using static System.Console;
using System.Globalization;

class Auction
{
    static void Main()
    {
        const int MIN = 10;

        Write("Please enter your bid >> ");
        string strBid = ReadLine();

        int intBid;
        double bidTwo;

        if (int.TryParse(strBid, out intBid))
        {
            AcceptBid(intBid, MIN);
        }
        else if (double.TryParse(strBid, out bidTwo))
        {
            AcceptBid(bidTwo, MIN);
        }
        else
        {
            AcceptBid(strBid, MIN);
        }
    }

    public static void AcceptBid(int bid, int min)
    {
        if (bid >= min)
            WriteLine("Bid accepted");
        else
            WriteLine("Bid not high enough");
    }

    public static void AcceptBid(double bid, int min)
    {
        if (bid >= min)
            WriteLine("Bid accepted");
        else
            WriteLine("Bid not high enough");
    }

    public static void AcceptBid(string bid, int min)
    {
        double bidTwo;

        if (bid.StartsWith("$"))
        {
            if (double.TryParse(bid.Substring(1), out bidTwo))
                AcceptBid(bidTwo, min);
            else
                WriteLine("Bid was not in correct format");
        }
        else if (bid.EndsWith("dollars"))
        {
            string num = bid.Substring(0, bid.Length - 7).Trim();
            if (double.TryParse(num, out bidTwo))
                AcceptBid(bidTwo, min);
            else
                WriteLine("Bid was not in correct format");
        }
        else
        {
            WriteLine("Bid was not in correct format");
        }
    }
}

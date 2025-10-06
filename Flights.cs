using static System.Console;
using System;

class Flights
{
    public static int[] flightNumbers = { 201, 321, 510, 633 };
    public static string[] airportCodes = { "AUS", "CRP", "DFW", "HOU" };
    public static string[] airportNames = { "Austin", "Corpus Christi", "Dallas Fort Worth", "Houston" };
    public static string[] times = { "0710", "0830", "0915", "1140" };

    public static void Main(string[] args)
    {
        Console.Write("Please enter flight number or airport code >> ");
        string request = Console.ReadLine();

        string result;
        int flightNum;

        if (int.TryParse(request, out flightNum))
        {
            result = GetFlightInfo(flightNum, flightNumbers, airportCodes, airportNames, times);
        }
        else
        {
            result = GetFlightInfo(request.ToUpper(), flightNumbers, airportCodes, airportNames, times);
        }

        Console.WriteLine(result);
    }

    public static string GetFlightInfo(int flight, int[] flightNumbers, string[] codes, string[] names, string[] times)
    {
        string result = "Flight #" + flight + " was not found";
        for (int i = 0; i < flightNumbers.Length; i++)
        {
            if (flight == flightNumbers[i])
            {
                result = "Flight #" + flight + " " + codes[i] + " " + names[i] + " Scheduled at: " + times[i];
            }
        }
        return result;
    }

    public static string GetFlightInfo(string code, int[] flightNumbers, string[] codes, string[] names, string[] times)
    {
        string result = "Flight to " + code + " was not found";
        for (int i = 0; i < codes.Length; i++)
        {
            if (code.Equals(codes[i]))
            {
                result = "Flight #" + flightNumbers[i] + " " + codes[i] + " " + names[i] + " Scheduled at: " + times[i];
            }
        }
        return result;
    }
}
using System;
using static System.Console;
using System.Globalization;

class Reverse3
{
    public static void Main()
    {
        int firstInt = 23;
        int middleInt = 45;
        int lastInt = 67;

        Console.WriteLine($"The numbers are {firstInt}, {middleInt}, {lastInt}");

        Reverse(ref firstInt, ref middleInt, ref lastInt);

        Console.WriteLine($"The numbers are {firstInt}, {middleInt}, {lastInt}");
    }

    public static void Reverse(ref int firstInt, ref int middleInt, ref int lastInt)
    {
        int flip = firstInt;
        firstInt = lastInt;
        lastInt = flip;
    }
}
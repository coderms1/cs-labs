using System;
using static System.Console;
using System.Globalization;

class Reverse4
{
    public static void Main()
    {
        int int_one = 23;
        int int_two = 45;
        int int_three = 55;
        int int_four = 67;

        Console.WriteLine($"The numbers are {int_one}, {int_two}, {int_three}, {int_four}");

        Reverse(ref int_one, ref int_two, ref int_three, ref int_four);

        Console.WriteLine($"The numbers are {int_one}, {int_two}, {int_three}, {int_four}");
    }

    public static void Reverse(ref int int_one, ref int int_two, ref int int_three, ref int int_four)
    {
        int swap1 = int_one;
        int swap2 = int_two;

        int_one = int_four;
        int_two = int_three;
        int_three = swap2;
        int_four = swap1;
    }
}

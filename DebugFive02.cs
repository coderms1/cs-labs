// Program asks user to enter a stock number
// If the stock number is not 209, 312, or 414 the user must reenter the number
// The program displays the correct price
using System;
using static System.Console;
using System.Globalization;

class DebugFive02
{
    static void Main()
    {
        const int ITEM209 = 209;
        const int ITEM312 = 312;
        const int ITEM414 = 414;
        const double PRICE209 = 12.99;
        const double PRICE312 = 16.77;
        const double PRICE414 = 109.07;
        double price = 0.0;
        string input;
        int stockNum = 0;

        Write("Please enter the stock number of the item you want: ");
        input = ReadLine();
        stockNum = Convert.ToInt32(input);

        while (stockNum != ITEM209 && stockNum != ITEM312 && stockNum != ITEM414)
        {
            WriteLine("Invalid stock number. Please enter again.");
            input = ReadLine();
            stockNum = Convert.ToInt32(input);
        }

        if (stockNum == ITEM209)
        {
            price = PRICE209;
        }
        else if (stockNum == ITEM312)
        {
            price = PRICE312;
        }
        else
        {
            price = PRICE414;
        }

        WriteLine("The price for item # {0} is {1}", stockNum, price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}

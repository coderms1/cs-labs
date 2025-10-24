// This program sums & averages the user-inputted temperatures, until '999' is entered.
// Only values -20 up to 130 degrees are accepted.
using System;
using static System.Console;
using System.Globalization;
class DailyTemps
{
    static void Main()
    {
        const double EXIT = 999;
        string inputString;
        double temp, averageTemp;
        double tempSum = 0;
        double tempCount = 0;

        do
        {
            Write("Enter temperature or type 999 to exit: ");
            inputString = ReadLine();
            temp = Convert.ToDouble(inputString);
            if (temp >= -20 && temp <= 130)
            {
                tempSum += temp;
                tempCount++;
                
            }
            else
            {
                Write("Valid temperatures range from -20 to 130. Please reenter temperature. ");
            }
        } while (temp != EXIT);

        averageTemp = (tempSum / tempCount);
        WriteLine("Number of temperatures: {0}. Average temperature: {1}.", tempCount, averageTemp);
    }
}

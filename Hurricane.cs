using System;
using static System.Console;
using System.Globalization;
class Hurricane
{
    static void Main()
    {
        Write("Enter the Wind Speed: ");
        int windSpeed = Convert.ToInt32(ReadLine());
        if (windSpeed >= 157) {
            WriteLine("This is a category 5 hurricane!");
        } if (windSpeed >= 130 && windSpeed <= 156) {
            WriteLine("This is a category 4 hurricane!");
        } if (windSpeed >= 111 && windSpeed <= 129) {
            WriteLine("This is a category 3 hurricane!");
        } if (windSpeed >= 96 && windSpeed <= 110) {
            WriteLine("This is a category 2 hurricane!");
        } if (windSpeed >= 74 && windSpeed <= 109) {
            WriteLine("This is a category 1 hurricane!");
        } if (windSpeed < 73) {
            WriteLine("This is not a hurricane.");
        }
    }
}

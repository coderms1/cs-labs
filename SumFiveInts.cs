// This program takes in 5 integers and produces the sum of them
using System;
using static System.Console;
using System.Globalization;
class SumFiveInts
{
	static void Main()
	{
	string userInput;
	int i;
	double value;
	double sum = 0;
		for (i = 0; i < 5; i++) 
		{
			Write("Enter an integer: ");
			userInput = ReadLine();
			value = Convert.ToDouble(userInput);
			sum += value;
		}
		WriteLine("The sum is: {0}", sum);

	}
}

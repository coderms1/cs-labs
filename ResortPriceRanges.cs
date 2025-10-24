using System;
using static System.Console;
using System.Globalization;
class ResortPriceRanges
{
	static void Main()
	{
		int [] prices = { 145, 160, 180, 200 };
		int [] nights = { 1, 2, 3, 4, 5, 6, 7, 8 };
		Write("Enter how many nights will you be staying: ");
		int days = Convert.ToInt32(ReadLine());
		double ppn = 0;
		double total = 0;
		if (days <= nights[1]) {
			total = days * prices[3];
			ppn = 200;
		}
		else if (days < nights[4] && days > nights[1]) {
			total = days * prices[2];
			ppn = 180;
		}
		else if (days < nights[7] && days > nights[3]) {
			total = days * prices[1];
			ppn = 160;
		}
		else if (days > nights[6]) {
			total = days * prices[0];
			ppn = 145;
		}
		WriteLine("Price per night is {0, 5}", ppn.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		WriteLine("Total for {0} night(s) is {1, 5}", days.ToString(), total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	}
}

// This Program Accepts a user input character and determines...
// ...whether or not it is UPPERCASE or LOWERCASE ~ using WHILE LOOP***using System;
using static System.Console;
using System.Globalization;
class EnterUppercaseLetters
{
	public static void Main()
	{
		string inputString; 
		const char QUIT = '!';
		char letter;
		WriteLine("Enter an uppercase letter >> ");
		inputString = ReadLine();
		letter = Convert.ToChar(inputString);
		while(letter != '!')
		{	
			if(letter >= 'A' && letter <= 'Z')
			{
				WriteLine("OK.");
			}
			else
			{
				WriteLine("Sorry - that was not an uppercase letter.");
			}
		Write("Enter an uppercase letter or {0} to quit ", QUIT);
		inputString = ReadLine();
		letter = Convert.ToChar(inputString);
		}
		
	}
		
}

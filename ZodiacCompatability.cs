using System; 
using System.Collections.Generic; 

class Program 
{ 
static string GetZodiacSign(int month, int day) 
{ 
if ((month == 3 && day >= 21) || (month == 4 && day <= 19)) 
return "Aries"; 
else if ((month == 4 && day >= 20) || (month == 5 && day <= 20)) 
return "Taurus"; 
else if ((month == 5 && day >= 21) || (month == 6 && day <= 20)) 
return "Gemini"; 
else if ((month == 6 && day >= 21) || (month == 7 && day <= 22)) 
return "Cancer"; 
else if ((month == 7 && day >= 23) || (month == 8 && day <= 22)) 
return "Leo"; 
else if ((month == 8 && day >= 23) || (month == 9 && day <= 22)) 
return "Virgo"; 
else if ((month == 9 && day >= 23) || (month == 10 && day <= 22)) 
return "Libra"; 
else if ((month == 10 && day >= 23) || (month == 11 && day <= 21)) 
return "Scorpio"; 
else if ((month == 11 && day >= 22) || (month == 12 && day <= 21)) 
return "Sagittarius"; 
else if ((month == 12 && day >= 22) || (month == 1 && day <= 19)) 
return "Capricorn"; 
else if ((month == 1 && day >= 20) || (month == 2 && day <= 18)) 
return "Aquarius"; 
else if ((month == 2 && day >= 19) || (month == 3 && day <= 20)) 
return "Pisces"; 
else return ""; 
} 

static List<string> GetCompatibility(string zodiacSign) 
{ 
Dictionary<string, List<string>> compatibility = new Dictionary<string, List<string>> 
{ 
{"Aries", new List<string>{"Leo", "Sagittarius"}}, 
{"Taurus", new List<string>{"Virgo", "Capricorn"}}, 
{"Gemini", new List<string>{"Libra", "Aquarius"}}, 
{"Cancer", new List<string>{"Scorpio", "Pisces"}}, 
{"Leo", new List<string>{"Aries", "Sagittarius"}}, 
{"Virgo", new List<string>{"Taurus", "Capricorn"}}, 
{"Libra", new List<string>{"Gemini", "Aquarius"}}, 
{"Scorpio", new List<string>{"Cancer", "Pisces"}}, 
{"Sagittarius", new List<string>{"Aries", "Leo"}}, 
{"Capricorn", new List<string>{"Taurus", "Virgo"}}, 
{"Aquarius", new List<string>{"Gemini", "Libra"}}, 
{"Pisces", new List<string>{"Cancer", "Scorpio"}} 
}; 
return compatibility.ContainsKey(zodiacSign) ? compatibility[zodiacSign] : new List<string>(); } 

static void Main(string[] args) 
{ 
Console.WriteLine("Welcome to the Zodiac Sign Compatibility Checker!"); 
Console.Write("Please enter your birth month (1-12): "); 
int month = int.Parse(Console.ReadLine()); 
Console.Write("Please enter your birth day (1-31): "); 
int day = int.Parse(Console.ReadLine()); 
if (month < 1 || month > 12 || day < 1 || day > 31) 
{ 
Console.WriteLine("Invalid input. Please enter a valid month (1-12) and day (1-31)."); 
} else { 
string zodiacSign = GetZodiacSign(month, day); 
Console.WriteLine($"Your zodiac sign is {zodiacSign}."); 
List<string> compatibleSigns = GetCompatibility(zodiacSign); 
if (compatibleSigns.Count > 0) 
{ 
Console.WriteLine("Your compatible signs are:"); 
foreach (string sign in compatibleSigns) 
{ 
Console.WriteLine($"- {sign}"); 
} 
} else { Console.WriteLine("Sorry, compatibility information is not available for your sign."); 
} 
} 
} 
}

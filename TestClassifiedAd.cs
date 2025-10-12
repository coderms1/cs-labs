using System;
using System.Globalization;
using static System.Console;

class ClassifiedAd
{
    const double PRICE_PER_WORD = 0.09;
    private string category;
    private int words;
    private double price;

    public string Category
    {
        get { return category; }
        set { category = value; }
    }

    public int Words
    {
        get { return words; }
        set
        {
            words = value;
            price = words * PRICE_PER_WORD;
        }
    }

    public double Price
    {
        get { return price; }
    }
}

class TestClassifiedAd
{
    static void Main(string[] args)
    {
        ClassifiedAd Ad_No1 = new ClassifiedAd();
        Ad_No1.Category = "Used Cars";
        Ad_No1.Words = 100;

        ClassifiedAd Ad_No2 = new ClassifiedAd();
        Ad_No2.Category = "Help Wanted";
        Ad_No2.Words = 60;

        WriteLine(
            "The classified ad with {0} words in category {1} costs {2}",
            Ad_No1.Words,
            Ad_No1.Category,
            Ad_No1.Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))
        );

        WriteLine(
            "The classified ad with {0} words in category {1} costs {2}",
            Ad_No2.Words,
            Ad_No2.Category,
            Ad_No2.Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))
        );
    }
}
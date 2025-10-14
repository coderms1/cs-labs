using System;
using static System.Console;
using System.Globalization;

public class Photo
{
    private int width;
    private int height;
    protected double price;

    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    public int Height
    {
        get { return height; }
        set { height = value; }
    }

    public double Price
    {
        get
        {
            if (width == 8 && height == 10)
                price = 3.99;
            else if (width == 10 && height == 12)
                price = 5.99;
            else
                price = 9.99;
            return price;
        }
    }

    public Photo()
    {
        width = 0;
        height = 0;
        price = 0.0;
    }

    public override string ToString()
    {
		return $"{GetType()} {width} X {height} Price: {Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
    }
}

public class MattedPhoto : Photo
{
    private string color;

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public MattedPhoto()
    {
        color = "";
    }

    public override string ToString()
    {
        return $"{GetType()} {color} matting {Width} X {Height} Price: {(Price + 10).ToString("C", CultureInfo.GetCultureInfo("en-US"))}";

    }
}

public class FramedPhoto : Photo
{
    private string material;
    private string style;

    public string Material
    {
        get { return material; }
        set { material = value; }
    }

    public string Style
    {
        get { return style; }
        set { style = value; }
    }

    public FramedPhoto()
    {
        material = "";
        style = "";
    }

    public override string ToString()
    {
        return $"{GetType()} {style}, {material} frame. {Width} X {Height} Price: {(Price + 25).ToString("C", CultureInfo.GetCultureInfo("en-US"))}";
    }
}

public class PhotoDemo
{
    public static void Main()
    {
        Photo p = new Photo();
        MattedPhoto mp = new MattedPhoto();
        FramedPhoto fp = new FramedPhoto();
    }
}
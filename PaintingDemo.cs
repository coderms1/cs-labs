using System;
using static System.Console;

class PaintingDemo
{
    static void Main(string[] args)
    {
        Room[] rooms = new Room[8];
        int length = 8;
        int width = 8;
        int height = 8;

        for (int i = 0; i < rooms.Length; i++)
        {
            rooms[i] = new Room(length, width, height);
            length += 2;
            width += 1;
            if (i % 2 == 1)
                height += 1;
        }

    for (int i = 0; i < rooms.Length; i++)
        {
        WriteLine("Size of room: {0} x {1} x {2} ft.", rooms[i].Length, rooms[i].Width, rooms[i].Height);
        WriteLine("\tSide A: {0} length x {1} height", rooms[i].Length, rooms[i].Height);
        WriteLine("\tSide B: {0} length x {1} height", rooms[i].Width, rooms[i].Height);
        WriteLine("\tArea: {0}", rooms[i].Area);
        WriteLine("\tPaint required (gallons): {0}", rooms[i].Gallons);
            }
    }
}

class Room
{
    int width, height, length, area, gallons;

    public Room(int length, int width, int height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
        ComputeArea();
        ComputeGallons();
    }

    public int Length
    {
        get => this.length;
    }

    public int Width
    {
        get => this.width;
    }

    public int Height
    {
        get => this.height;
    }

    public int Area
    {
        get => this.area;
    }

    public int Gallons
    {
        get => this.gallons;
    }

    void ComputeArea()
    {
        this.area = (this.length * this.height * 2) + (this.width * this.height * 2);
    }

    void ComputeGallons()
    {
        const int GAL_SQ_FT = 350;
        this.gallons = this.area / GAL_SQ_FT;
        if (this.area % GAL_SQ_FT != 0)
            this.gallons++;
    }
}
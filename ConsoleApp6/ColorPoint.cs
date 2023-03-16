using System;

class ColorPoint
{
    private int x;
    private int y;
    private int red;
    private int green;
    private int blue;

    public ColorPoint(int x, int y, int red, int green, int blue)
    {
        if (x < 0)
        {
            throw new ArgumentException("no negative values allowed", nameof(x));
        }

        if (y < 0)
        {
            throw new ArgumentException("no negative values allowed", nameof(y));
        }

        if (red < 0 || red > 255)
        {
            throw new ArgumentException("valid range is 0 to 255", nameof(red));
        }

        if (green < 0 || green > 255)
        {
            throw new ArgumentException("valid range is 0 to 255", nameof(green));
        }

        if (blue < 0 || blue > 255)
        {
            throw new ArgumentException("valid range is 0 to 255", nameof(blue));
        }

        this.x = x;
        this.y = y;
        this.red = red;
        this.green = green;
        this.blue = blue;
    }

    public void ChangeColorPoint(int red, int green, int blue)
    {
        if (red < 0 || red > 255)
        {
            throw new ArgumentException("valid range is 0 to 255", nameof(red));
        }

        if (green < 0 || green > 255)
        {
            throw new ArgumentException("valid range is 0 to 255", nameof(green));
        }

        if (blue < 0 || blue > 255)
        {
            throw new ArgumentException("valid range is 0 to 255", nameof(blue));
        }

        this.red = red;
        this.green = green;
        this.blue = blue;
    }

    public void ShowColorPoint(string text)
    {
        Console.WriteLine(text);
    }

    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    public int Red
    {
        get { return red; }
    }

    public int Green
    {
        get { return green; }
    }

    public int Blue
    {
        get { return blue; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ColorPoint colorPoint = new ColorPoint(5, 5, 23, 3, 14);

            Console.WriteLine($"x: {colorPoint.X}");
            Console.WriteLine($"y: {colorPoint.Y}");
            Console.WriteLine($"red: {colorPoint.Red}");
            Console.WriteLine($"green: {colorPoint.Green}");
            Console.WriteLine($"blue: {colorPoint.Blue}");

            colorPoint.ChangeColorPoint(255, 0, 0); // change color to red
            Console.WriteLine($"red: {colorPoint.Red}");
            Console.WriteLine($"green: {colorPoint.Green}");
            Console.WriteLine($"blue: {colorPoint.Blue}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }
}

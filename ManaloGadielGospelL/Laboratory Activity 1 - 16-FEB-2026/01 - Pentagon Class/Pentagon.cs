using System;

class Pentagon
{
    private double side;
    public Pentagon()
    {
        side = 0;
    }
    public Pentagon(double side)
    {
        this.side = side;
    }
    public double GetPerimeter()
    {
        return 5 * side;
    }
    public double GetArea()
    {
        return (Math.Sqrt(5*(5+2 * Math.Sqrt(5))) * Math.Pow(side, 2))/4;
    }
    public void Display(string label)
    {
        Console.WriteLine(label);
        Console.WriteLine("--------------------------");
        Console.WriteLine("Side length: " + side);
        Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
        Console.WriteLine($"Area: {GetArea():F3}");
        Console.WriteLine();
    }
    static void Main()
    {
        Pentagon p1 = new Pentagon();
        p1.Display("Pentagon p1");

        Pentagon p2 = new Pentagon(5);
        p2.Display("Pentagon p2");
    }
}


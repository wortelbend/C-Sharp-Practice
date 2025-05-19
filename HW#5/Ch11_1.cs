using System;

class MathUtility
{
    // Cube 方法 - int 版本
    public static int Cube(int x)
    {
        return x * x;
    }

    // Cube 方法 - double 版本
    public static double Cube(double x)
    {
        return x * x;
    }

    // MinElement 方法 - 傳入3個int
    public static int MinElement(int a, int b, int c)
    {
        return Math.Min(a, Math.Min(b, c));
    }

    // MinElement 方法 - 傳入4個int
    public static int MinElement(int a, int b, int c, int d)
    {
        return Math.Min(a, Math.Min(b, Math.Min(c, d)));
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cube(4) = " + MathUtility.Cube(4));          // int
        Console.WriteLine("Cube(3.2) = " + MathUtility.Cube(3.2));      // double

        Console.WriteLine("MinElement(7, 2, 9) = " + MathUtility.MinElement(7, 2, 9));
        Console.WriteLine("MinElement(8, 5, 3, 6) = " + MathUtility.MinElement(8, 5, 3, 6));
    }
}

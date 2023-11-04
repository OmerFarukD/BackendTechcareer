namespace Day_3_Static;

public class CalculatorStatic
{
    public static void Topla(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }
    public static void Carpma(int a, int b)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }

    public static void Bolme(double a, double b)
    {
        Console.WriteLine($"{a} / {b} = {a / b}");
    }

    public static void Cikarma(int a, int b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }

}

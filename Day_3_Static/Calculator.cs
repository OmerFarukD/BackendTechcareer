using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Static;

public class Calculator
{
    public void Topla(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a+b}");
    }
    public void Carpma(int a, int b)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }

    public void Bolme(double a, double b)
    {
        Console.WriteLine($"{a} / {b} = {a / b}");
    }

    public void Cikarma(int a, int b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }
}

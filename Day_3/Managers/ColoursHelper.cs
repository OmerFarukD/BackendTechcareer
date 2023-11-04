using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3.Managers;

public class ColoursHelper
{
    public static string ColourName(Colour colour)
    {
        Dictionary<Colour,string> colours = new Dictionary<Colour, string>()
        {
            {Colour.Red,"Kırmızı" },
            { Colour.Black,"Siyah"},
            {Colour.Yellow, "Sarı" },
            { Colour.Green, "Yeşil"}
        };
        return colours[colour];
    }
}

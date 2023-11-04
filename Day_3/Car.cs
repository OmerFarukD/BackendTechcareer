using Day_3.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3;

public class Car
{
    public int ModelYear { get; set; }
    public string BrandName { get; set; }
    public double Price { get; set; }
    public Colour Colour { get; set; }

    public override string ToString()
    {
        return $"Kaç Model : {ModelYear}, Marka Adı : {BrandName}, Değeri : {Price} Rengi : {ColoursHelper.ColourName(Colour)}";
    }
}

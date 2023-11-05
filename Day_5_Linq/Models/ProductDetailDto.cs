using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Linq.Models;

public class ProductDetailDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Stock { get; set; }
    public double Price { get; set; }
    public string CategoryName { get; set; }

    public override string ToString()
    {
        return $"ProductId :{ProductId},ProductName: {ProductName}, Stock:{Stock}, Price : {Price}, CategoryName :{CategoryName} ";
    }
}

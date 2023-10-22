using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_OOP;
public record Product(string Name, string Description, double Price)
{
    public override string ToString()
    {
        return $" Ürün adı : {Name}, Ürün Açıklaması : {Description}, Ürün Değeri : {Price}";
    }
}

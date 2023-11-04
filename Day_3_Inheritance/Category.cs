using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Inheritance;

public class Category : EntityBase
{
    public string CategoryName { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Kim Oluşturdu : {CreatedBy}, Ne Zaman : {CreatedDate}, Kategori Adı : {CategoryName}";
    }


}

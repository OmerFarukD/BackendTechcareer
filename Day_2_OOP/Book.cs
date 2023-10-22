using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_OOP;

public struct Book
{
    public string Adi;
    public string Yazar;
    public int SayfaSayısı;

    public override string ToString()
    {
        return $" KİTAP ADI : {Adi}, Kitap Yazarı : {Yazar} Kitap Sayfası : {SayfaSayısı}";
    }

}



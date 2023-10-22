//Topla(2,6);
//Topla(4,6);
//KisiBilgileriYazdir("Göktuğ","Yamak",25);
//KisiBilgileriYazdir(surname: "Doğan", age: 25, name: "Ahmet");
//KisiBilgileriYazdir("Göktuğ", "Yamak", 25);
//KisiBilgileriYazdir(surname: "Doğan", age: 25, name: "Ahmet");

//Console.WriteLine("1. Sayıyı giriniz");
//double sayi1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Lütfen işlemlerden birini seçiniz (+,-,/,*)");
//string @operator = Console.ReadLine();

//Console.WriteLine("2. Sayıyı giriniz.");
//double sayi2 = Convert.ToDouble(Console.ReadLine());

//switch (@operator)
//{
//    case "+": Toplama(sayi1, sayi2);
//        break;

//    case "-": Cikarma(sayi1, sayi2); 
//        break;
//    case "*": Carpma(sayi1, sayi2);
//        break;
//    case "/":
//        Bolme(sayi1, sayi2);
//        break;

//    default: Console.WriteLine("Geçersiz karakter girdiniz.");
//        break;
//}

//var sonuc=Kuvvet(m:4, a:5);
//Console.WriteLine(sonuc);

//var faktoriyelsonuc = Faktoriyel2(6);
//Console.WriteLine(faktoriyelsonuc);

//Console.WriteLine(ReverseMetin("Techcareer Bootcamp 2. GÜN"));

//int[] sayilar = { 10, 20, 30, 40, 21, 25, 66, 88, 101 };

//Console.WriteLine($"sayilar dizisinin en büyük sayısı : {EnbuyukSayi(sayilar)}");

//Console.WriteLine(ToplaCoklu(1,2,3,4,5,6));
//Console.WriteLine(ToplaCoklu(-1,-2,-3,-4));
//Console.WriteLine(EnbuyukSayiCoklu(1,2,3,8,7,9,11,101,102,44,55,66,22));

int sonucBolum;
int sonucKalan;
BolmeIslemi(17,10, out sonucBolum, out sonucKalan);

// Sisteme üye olduk 
// parola123SecretkeySecretkey-> ASDFHGASDFGHSAFDLKSAJFKJHDSG123546 HmacSha256, HmacSha512 ,Salt
Console.WriteLine($" Bölme işleminin bölümü : {sonucBolum}, kalanı ise : {sonucKalan}");

Console.WriteLine(CarpmaIslemi(1,2,4,5,9,10));
EkranaYaz("Elma","Armut","Meyve","Kiraz","Üzüm","Elazığ","İcardi");

void Topla(int sayi, int sayi2)
{
    Console.WriteLine(sayi+sayi2);
}
void BolmeIslemi(int bolunen, int bolen, out int bolum, out int kalan)
{
    bolum = bolunen / bolen;
    kalan = bolunen % bolen;
}
void KisiBilgileriYazdir(string name, string surname, int age)
{
    Console.WriteLine($" Kişinin adı : {name}, Kişinin Soyadı : {surname}, kişinin yaşı : {age}");
}

// Bir hesap makinesi uygulaması yapalım switch-case(if-else) kullanarak 
// Kullanıcıdan ilk başta 1. sayıyı sonrasında operatörlerden birini almak(string), sonrasında 2. sayıyı alıp
// sonucu ekrana bastıralım
// Toplama(a,b), Cikarma(a,b), Carpma(a,b), Bolme(a,b)

void Toplama(double a, double b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

void Cikarma(double a, double b)
{
    Console.WriteLine($"{a} - {b} = {a-b}");
}

void Carpma(double a, double b)
{
    Console.WriteLine($"{a} * {b} = {a * b}");
}

void Bolme(double a, double b)
{
    Console.WriteLine($"{a} / {b} = {a / b}");
}

// ivme ve kütleyi  alarak  Cismin kuvvetini hesaplayan Metodu yazalım

double Kuvvet(double m, double a)
{
    return m*a;
}
// girilen parametrenin faktöriyelini alan bir metod yazalım
// iterative
// recursive

int Faktoriyel1(int n)
{
    int sonuc = 1;
    for (int i =1;i<=n;i++)
    {
        sonuc *=i;
    }
    return sonuc;
}


int Faktoriyel2(int n)
{
    if (n == 1) return 1;

    return n * Faktoriyel2(n - 1);
}

// girilen parametredeki metni ters çeviren metod

string ReverseMetin(string metin)
{
    char[] chars = metin.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}

int EnbuyukSayi(int[] sayilar)
{
    int enBuyuk = int.MinValue;
    for(int i=0; i < sayilar.Length; i++)
    {
        if (sayilar[i]>enBuyuk) enBuyuk = sayilar[i];
    }
    return enBuyuk;
}

int ToplaCoklu(params int[] sayilar)
{
    int sum = 0;
    foreach (var sayi in sayilar)
    {
        sum += sayi;
    }
    return sum;
}
int EnbuyukSayiCoklu(params int[] sayilar)
{
    int enBuyuk = int.MinValue;
    for (int i = 0; i < sayilar.Length; i++)
    {
        if (sayilar[i] > enBuyuk) enBuyuk = sayilar[i];
    }
    return enBuyuk;
}
int CarpmaIslemi(params int[] sayilar)
{
    int multiply = 1;
    foreach (var sayi in sayilar) { 
        multiply *= sayi; 
    }
    return multiply;
}

// Todo : geçtiğim argümanlardan içinde e olan bütün kelimeleri ekrana bastırsın.

void EkranaYaz(params string[] kelimeler)
{
    foreach (var kelime in kelimeler)
    {
        if (kelime.Contains("e") || kelime.Contains("E"))
        {
            Console.WriteLine(kelime);
        }
    }
}

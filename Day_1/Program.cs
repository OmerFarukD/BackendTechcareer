//Console.WriteLine("Bootcampin ilk günü");
//Console.WriteLine(1+45);
//Console.WriteLine("1. Sayıyı giriniz.");
//int sayi1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("2. Sayıyı giriniz.");
//int sayi2 = Convert.ToInt32(Console.ReadLine());
//int toplam = sayi1 + sayi2;
//Console.WriteLine(sayi1+sayi2);

//Console.WriteLine(" 2 sayının toplamı :"+ sayi1 +" +"+" "+sayi2 +" = "+toplam);
// Yorum satırına alma işi ctrl + k + c

// String interpolation
//Console.WriteLine($"2 sayının toplamı : {sayi1} + {sayi2} = {toplam}");

//string ad = "Gülsu";
//string soyad = "Doğan";

//string tamIsim = ad + " " + soyad;

//Console.WriteLine(tamIsim.Contains("A"));

//double ondalik1 = 10.5;
//double ondalik2 = 10.7;
// Yorum satırını eski haline getirme ctrl + k + u
//double a = 25;
//double b = 10;

//Console.WriteLine(a/b);

// bool veri tipi
// Karşılaştırma operatörleri
//Console.WriteLine($"{ondalik1} ve {ondalik2} sayıları eşit midir = {ondalik1==ondalik2}");
//Console.WriteLine($"{ondalik1} ve {ondalik2} sayıları eşit değil midir = {ondalik1 != ondalik2}");
//Console.WriteLine($"{ondalik1} , {ondalik2} den büyük müdür ={ondalik1 > ondalik2}");
//Console.WriteLine($"{ondalik1} , {ondalik2} den küçük müdür ={ondalik1 < ondalik2}");
//Console.WriteLine($"{ondalik1} , {ondalik2} den büyük eşit midir ={ondalik1 >= ondalik2}");
//Console.WriteLine($"{ondalik1} , {ondalik2} den küçük eşit midir ={ondalik1 <= ondalik2}");

// konsoldan girdi alınacak ve girilen yaş 18 in altındaysa ehliyet alamaz 18 yaşından büyük eşit ise ehliyet alabilir

//Console.WriteLine("Lütfen Yaşınızı giriniz.");
//int age = Convert.ToInt32(Console.ReadLine());

//if (age>=18)
//{
//    Console.WriteLine("Ehliyet alabilir");
//}
//else
//{
//    Console.WriteLine("Ehliyet alamaz");
//}
// if else ile not harflendirmesi
//Console.WriteLine("Lütfen notunuzu giriniz : ");
//double not = Convert.ToDouble(Console.ReadLine());

//if (not >= 50 && not<=60)
//{
//    Console.WriteLine("Not Harfiniz D dir");
//}
//else if (not > 60 && not <= 70)
//{
//    Console.WriteLine("Not Harfiniz C dir");
//}

//else if (not > 70 && not <= 80)
//{
//    Console.WriteLine("Not Harfiniz B dir");
//}
//else if (not > 80 && not < 90)
//{
//    Console.WriteLine("Not Harfiniz A dir");
//}

//else if (not > 90 && not < 100)
//{
//    Console.WriteLine("Not Harfiniz S dir");
//}

//else if (not<50)
//{
//    Console.WriteLine("Kaldınız.");
//}
//else
//{
//    Console.WriteLine("Yanlış sayı girdiniz");
//}
// konu: Kullanıcıdan 1-7 ye kadar sayı alınır ve hangi güne denk geliyorsa o günün adı ekrana bastırılır

//Console.WriteLine("1 den 7 ye kadar bir sayı giriniz");
//int dayOfWeek = Convert.ToInt32(Console.ReadLine());
// 1. Yöntem
//switch (dayOfWeek)
//{
//        case 1:
//        Console.WriteLine("Pazartesi");
//        break;
//        case 2: Console.WriteLine("Salı");
//        break;
//        case 3: Console.WriteLine("Çarşamba");
//        break;
//        case 4: Console.WriteLine("Perşembe");
//        break;
//        case 5: Console.WriteLine("Cuma");
//        break;
//        case 6: Console.WriteLine("Cumartesi");
//        break;
//        case 7: Console.WriteLine("Pazar");
//        break;
//        default:Console.WriteLine("Yanlış karakter girdiniz.");
//        break;
//}
// 2. Yöntem
//string name = dayOfWeek switch
//{
//    1 => "Pazartesi",
//    2 => "Salı",
//    3=> "Çarşamba",
//    4=> "Perşembe",
//    5 => "Cuma",
//    6 =>"Cumartesi",
//    7=> "Pazar",
//    _=> "Geçersiz karakter girdiniz."
//};
//Console.WriteLine(name);
// Döngüler
// ilk 9 sayıyı ekrana bastıran kod
// 1 2 3 4 5 6 7 8 9
//for (int i=1; i<=9;i+=2)
//{
//    Console.WriteLine(i);
//}

// 1 den 20 ye kadar olan tüm çift sayıları ekrana bastıran kodu yazınız.
// 1. Yöntem
//for (int i =1; i<=20;i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

// 2. Yöntem
//for (int i = 2; i<=20;i+=2)
//{
//    Console.WriteLine(i);
//}

//Arraylar statik yapılıdır.
string[] sehirler = { "Ankara", "İzmir", "Aydın", "Bursa", "İstanbul","Elazığ"};

// 1. Yöntem
//for (int i =0;i<=sehirler.Length;i++)
//{
//    Console.WriteLine(sehirler[i]);
//}

// 2. Yöntem Foreach yöntemi


//foreach (string sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}

// Şehirler dizisinden ismi içerisinde "r" olan şehirleri ekrana yazdırsın
// Şehirler dizinden A ile başlayan şehirleri ekrana bastırın.
// Sonu a ile biten şehirleri ekrana bastırın.

Console.WriteLine("Şehirler dizisinde 'r' harfi geçen şehirler : ");
foreach (string sehir in sehirler)
{
    if (sehir.Contains("r") == true)
    {
        Console.WriteLine(sehir);
    }
}

Console.WriteLine("Şehirler dizinden A ile başlayan şehirler:");
foreach (var sehir in sehirler)
{
    if (sehir.StartsWith("A"))
    {
        Console.WriteLine(sehir);
    }
}

Console.WriteLine("Sonu a ile biten şehirler.");
foreach (var sehir in sehirler)
{
    if (sehir.EndsWith("a"))
    {
        Console.WriteLine(sehir);
    }
}

// Bütün kuralları tek if ile || (veya operatörü)
Console.WriteLine("3 Kuralara tamamına  uyan şehirler");
foreach (var s in sehirler)
{
    if(s.Contains("r") && s.StartsWith("A")&& s.EndsWith("a"))
    {
        Console.WriteLine(s);
    }
}

Console.WriteLine("Şehirleri While Döngüsü ile ekrana bastırma");
int i = 0;
while (i<sehirler.Length)
{
    Console.WriteLine(sehirler[i]);
    // 1. Yöntem
    // i = i + 1;

    //2. Yöntem
    //i += 1;
    i++;
}
// Çarpım tablosu 2 tane for döngüsü kullanarak yapınız 1 den 10 a kadar 

for(int a =1; a <= 10; a++)
{
    for(int j =1; j<=10; j++)
    {
        Console.WriteLine($"{a} * {j} = {a*j}");
    }
}


for (int a =1;a<=6; a++)
{
    for (int b=1;b<=a;b++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

for(int a = 0; a<=10; a++)
{
    if(a == 5)
    {
        break;
    }
    Console.WriteLine(a);
}
for (int a = 0; a <= 10; a++)
{
    if (a == 5)
    {
        continue;
    }
    Console.WriteLine(a);
}

Console.WriteLine("Bir değişiklik yaptım.");

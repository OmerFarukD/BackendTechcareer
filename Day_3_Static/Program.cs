using Day_3_Static;

//Calculator calculator = new Calculator();

//Console.WriteLine("1. Sayıyı Giriniz.");
//int sayi1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("2. Sayıyı Giriniz.");
//int sayi2 = Convert.ToInt32(Console.ReadLine());

//calculator.Topla(sayi1,sayi2);
//calculator.Carpma(sayi2,sayi1);
//calculator.Cikarma(sayi1,sayi2);
//calculator.Bolme(sayi1,sayi2);


// Statik metodlar.
//CalculatorStatic.Topla(sayi1,sayi2);
//CalculatorStatic.Carpma(sayi1, sayi2);
//CalculatorStatic.Cikarma(sayi1,sayi2);
//CalculatorStatic.Bolme(sayi1,sayi2);

// Biz bir sisteme kayıt olduğumuzda veri tabanında parolalarımız nasıl görünür.

byte[] passwordHash;
byte[] passwordSalt;

Console.WriteLine("Lütfen şifrenizi girin.");
string password = Console.ReadLine();
SecurityHelper.CreatePasswordHash(password,out passwordHash, out passwordSalt);

Console.WriteLine($"Şifreniz : {password}");
Console.WriteLine($"Şifrenizin Hashi:");
foreach (var hash in passwordHash)
{
    Console.Write(hash);
}

Console.WriteLine();

Console.WriteLine($"Şifrenizin Saltı:");
foreach (var salt in passwordSalt)
{
    Console.Write(salt);
}


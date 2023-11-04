Console.WriteLine("Hello, World!");

// List yapısı
// Listeler Referans tiplidir

//List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
//numbers.Add(11);
//numbers.Add(10);
//numbers.AddRange(new int[] {25,27,26,30});
//// 1.Yöntem
////foreach (int number in numbers)
////{
////    Console.WriteLine(number);
////}
//// 2.Yöntem
////numbers.ForEach(y=> Console.WriteLine(y));
//Console.WriteLine($"numbers listesi içerisinde 30 varmı ? : {numbers.Contains(30)}");
//Console.WriteLine($"numbers listesi içinde 30 un indexi nedir : {numbers.IndexOf(30)}");
//Console.WriteLine($"numbers listesinin kaç elemanlıdır : {numbers.Count}");

//// iki tane listem olacak numbers listesi içerisindeki tek ve çift sayıları ayıracak ve bunları ekrana bastıracak
//// evenNumbers
//// oddNumbers 


//List<int> evenNumbers = new List<int>();
//List<int> oddNumbers = new List<int>();
//// 1. Yöntem
////foreach (int number in numbers)
////{
////    if(number %2==0)
////        evenNumbers.Add(number);
////    else
////    {
////        oddNumbers.Add(number);
////    }

////}

//// 2. Yöntem
//evenNumbers = numbers.FindAll(number => number % 2==0);
//oddNumbers = numbers.FindAll(number => number % 2 !=0);

//// 3. yöntem

////evenNumbers = numbers.Where(x=>x%2 ==0).ToList();
////oddNumbers = numbers.Where(x => x % 2 != 0).ToList();

//Console.WriteLine("Çift sayılar :");
//evenNumbers.ForEach(x=> Console.Write($"{x}, "));
//Console.WriteLine();
//Console.WriteLine("Tek Sayılar sayılar :");
//oddNumbers.ForEach(x => Console.Write($"{x},"));


HashSet<int> hashNumbers = new HashSet<int>() { 1,2,3,3,4,4,4,5,5,5,6,5,6,2,1};

foreach(int x in hashNumbers)
{
    Console.WriteLine(x);
}
hashNumbers.Clear();

// Dictionary 
Dictionary<string,int> meyveler = new Dictionary<string,int>();
meyveler.Add("Elma",12);
meyveler.Add("Üzüm", 25);
meyveler.Add("Karpuz",30);
Console.WriteLine($" Elmanın fiyatı : {meyveler["Elma"]}");

meyveler["Üzüm"] = 20;
Console.WriteLine($" Üzümün fiyatı : {meyveler["Üzüm"]}");

if (meyveler.ContainsKey("Karpuz"))
{
    Console.WriteLine($" Karpuz fiyatı : {meyveler["Karpuz"]}");
}
else
{
    Console.WriteLine("Karpuz mevcut değil.");
}

foreach (KeyValuePair<string,int> meyve in meyveler)
{
    Console.WriteLine($"Meyve adı : {meyve.Key}, Fiyatı : {meyve.Value}");
}
meyveler.Remove("Karpuz");

foreach (var meyve in meyveler)
{
    Console.WriteLine($"Meyve adı : {meyve.Key}, Fiyatı : {meyve.Value}");
}

var Keys = meyveler.Keys;
foreach (var key in Keys)
{
    Console.WriteLine(key);
}

var values = meyveler.Values;
foreach (var value in values)
{
    Console.WriteLine(value); 
}
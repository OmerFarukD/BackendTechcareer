// Senaryo Ürünler ve kategori listeleri üzerinden çeşitli örnekler yapacağız.
using Day_5_Linq.Data;
using Day_5_Linq.Models;

var products = Repository.Products;
var categories = Repository.Categories;

// Tüm ürünlerden categoryId si 1 olan ürünleri listeleyin.

// 1. Yöntem
//foreach (var product in products)
//{
//    if (product.CategoryId == 1)
//    {
//        Console.WriteLine(product);
//    }
//}

//2.Yöntem
//var prodList = from p in products where p.CategoryId == 1 select p;

//foreach (var p in prodList)
//{
//    Console.WriteLine(p);
//}

//3. Yöntem
//products.Where(p => p.CategoryId == 1).ToList().ForEach(p=>Console.WriteLine(p));

// Tüm ürünlerden içerisinde App geçen ürünleri listeleyin 

//1. Yöntem 
//foreach (var p in products)
//{
//    if (p.Name.Contains("App"))
//    {
//        Console.WriteLine(p);
//    }
//}

// 2. Yöntem 
//var pList = from p in products where p.Name.Contains("App") select p;
//foreach (var p in pList)
//{
//    Console.WriteLine(p);
//}

//3. Yöntem
//products.Where(p=>p.Name.Contains("App")).ToList().ForEach(p=> Console.WriteLine(p));

// Ürünlerin fiyatlarının toplamı olan kodu yazınız.

//1. Yöntem

//double total = 0;
//foreach (var p in products)
//{
//    total += p.Price;
//}

//Console.WriteLine("Tüm ürünlerin toplamı : " + total);

//2. Yöntem
//var total = products.Sum(x=>x.Price);
//Console.WriteLine($"Tüm ürünlerin fiyatlarının toplamı : {total}");


// Todo : CategoryId si 2 olan ürünlerin Price toplamlarını bulunuz.(Where-Sum)
//var total = products.Where(p => p.CategoryId == 2).Sum(x=>x.Price);
//Console.WriteLine($"Category Id si 2 olan ürünlerin toplamı : {total}");

// TODO: tüm ürünlerin fiyat ortalamasını alan kodu yazınız.

//var average = products.Average(p => p.Price);
//Console.WriteLine($"Tüm ürünlerin ortalaması : {average}");

// Todo : Category Id si 3 olan ürün var mı 
//var productIsPresent = products.Any(x=>x.CategoryId==4);
//Console.WriteLine($"Category Id si 4 olan ürün var mı : {productIsPresent}");

// TODO: Ürünün id si 1 olan ürünün değerlerini ekrana basınız
//var product = products.SingleOrDefault(x=>x.Id==1);
//Console.WriteLine(product);

// TODO: Tüm ürünlerin sadece isimlerini ekrana bastırınız.
//products.Select(x=> x.Name).ToList().ForEach(p=>Console.WriteLine(p));

// TODO: Tüm ürünlerin isim stok ve price değerlerini ekrana bastıran kodu yazınız.

// 1. Yöntem
//var list = products.Select(x=> new {isim =x.Name, stok=x.Stock, price = x.Price}).ToList(); 
//foreach(var item in list)
//{
//    Console.WriteLine($"isim : {item.isim}, stok = {item.stok}, price = {item.price}");
//}

//2. Yöntem
//var list = from p in products select new {isim = p.Name, stok=p.Stock, price =p.Price};

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

// TODO : CategoryId lerine göre ürünleri gruplandıralım

//var grouppedProducts = products.GroupBy(x => x.CategoryId).ToDictionary(g=>g.Key, g=>g.ToList());
//foreach (var group in grouppedProducts)
//{
//    Console.WriteLine($"{group.Key} Category Id sine sahip ürünler");
//    group.Value.ForEach(x => Console.WriteLine(x));
//}

// Tüm ürünleri Fiyatları artacak şekilde sıralayınız.
//products.OrderBy(x=>x.Price).ToList().ForEach(p=>Console.WriteLine(p));

// TODO: Tüm ürünlerin fiyatını azalan bir şekilde sıralayınız.
//products.OrderByDescending(x => x.Price).ToList().ForEach(p => Console.WriteLine(p));

var details = from p in products
              join c in categories on p.CategoryId equals c.Id
              select new ProductDetailDto
              {
                  CategoryName = c.Name,
                  Price = p.Price,
                  ProductId = p.Id,
                  ProductName = p.Name,
                  Stock = p.Stock
              };
foreach (var item in details)
{
    Console.WriteLine(item);
}

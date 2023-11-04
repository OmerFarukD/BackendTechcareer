// Product Diye bir classımız olsun ürünün kdv li fiyatını ekrana gösteren senaryoyu yazınız.
// Book adında bir classımız olsun Yazar adı küçük harfle girilmiş ise ilk harfleri büyük olsun
// Kitap fiyatına kdv uygulansın;
using Day_3;
using Day_3.Managers;

//Product product = new Product();

//product.SetName("Laptop");
//product.SetPrice(25000);
//Console.WriteLine($"{product.GetName()} -> {product.GetPrice()}");

//Person person = new Person();

//person.Name = "Ozan Cem";
//person.Surname = "Dedeoğlu";
//person.Email = "dedeoglu@gmail.com";
//person.Password = "denemeAbc";
//Console.WriteLine(person);

//Book book = new Book()
//{
//    Author = "sait faik abasıyanık",
//    Price = 125,
//    Title = "Deneme Başlığı"
//};
//Console.WriteLine(book);

Car car = new Car()
{
    BrandName ="Bmw",
    Colour =Colour.Red,
    ModelYear= 2015,
    Price = 10000
};

Console.WriteLine(car);

CarManager carManager = new CarManager();
carManager.Add(car);


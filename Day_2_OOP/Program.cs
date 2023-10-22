// Person adında bir class oluşturulur ve gerekli işlemler yapılır.
// Oluşturulan nesnelerin ekran bastırılması

// classlar referans tipli dir
// referans tipler oluşturulurken new anahtar sözcüğü ile oluşturulur.

using Day_2_OOP;


Person person = new();
person.name = "Ömer";
person.age = 25;
person.surname = "Doğan";
person.phone = "0123456789";
//Console.WriteLine(person);
Console.WriteLine(person);

// Dependency Injection yöntemi

// 2. Yöntem
Person person1 = new Person();
person1.name = "t";
person1.age = 15;
person1.surname = "Şahin";
person1.phone = "";
// IsNullOrEmpty çalışmaz IsNullOrWhiteSpace çalışır                                ";
Person.Add(person1);
//3. Yöntem 
var person2 = new Person(25,"Evren","Çakar","05341022567894");
person2.name = "Ahemt";
Console.WriteLine(person2);


KayıtOl kayıtOl = new(username: "deneme",password:"deneme");
kayıtOl.Success();
KayıtOl kayıtOl1 = new(username: "deneme", password: "deneme", city:"Malatya",state:"Doğu Anadolu");
kayıtOl1.Success();
// record -> immutable data classlardır
// struct-> Yapı olarak karşımıza gelir
Product product = new Product(Name: "Deneme", Description: " Deneme", Price: 25);

Person person3 = new()
{
    name = "asdasd",
    age = 25,
    phone="12345",
    surname = "KSADJLKASJDLKSA"
};
person3.name = "asdasd";
Console.WriteLine(person3);
Console.WriteLine(product);

Book book;
book.Adi = "Abasıynaık";
book.Yazar = "Sait Faik";
book.SayfaSayısı = 125;
Console.WriteLine(book);


//**************Struct**************
// Structlar değer tipindedir
// Bellekte stack hafızada tutulur
// new Anahtar sözcüğü kullanmadan oluşturulabilir
// Büyük veri setleri için değil , küçük veri setleri için uyfundur
// structlar bir classtan miras alamazlar sadece interface den miras alabilirler

// **************Record**************
// .Net5 VE C sharp 9.0 ile tanıtıldı.
// Recordların temel amacı veriyi saklamak genellikle adına veri taşıyıcıları da denir
// İmmutable classlardır




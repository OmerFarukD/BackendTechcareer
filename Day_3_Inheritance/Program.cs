

// Product ve Category diye 2 Tane veritabanı tablomuzun olduğunu düşünelim bu tablolar arasında basit crud operasyonlarını
// yapınız.

//Create- Read - Update - Delete 
using Day_3_Inheritance;
using Day_3_Inheritance.Managers;
// Interface ler sözleşmedir
// Interfaceler Soyut classlardır yani new anahtar sözcüğü ile nesnesi üretilemez.


//Category category = new Category()
//{
//    Id=1,
//    CreatedBy = "Gülsü Doğan",
//    CreatedDate = "2023",
//     CategoryName = "Bilgisayar"
//};

//Product product = new Product()
//{
//    Id = 2,
//    CreatedBy = "Gülsü Doğan",
//    CreatedDate = "2023",
//    Name = "Msi",
//    Price = 1200
//};
//Console.WriteLine(category);
//Console.WriteLine(product);
ICrudService crudService = new CategoryService();
crudService.Add();
crudService.Delete();
crudService.GetAll();
crudService.Update();

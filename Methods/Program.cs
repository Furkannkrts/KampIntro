// See https://aka.ms/new-console-template for more information
using Methods;

string productname = "Elma";
double price = 15;
string aciklama = "amasya elması";

Product product1 = new Product();
product1.Name = "Elma";
product1.Price = 15;
product1.Explanation = "Amasya";

Product product2= new Product();
product2.Name = "Karpuz";
product2.Price = 80;
product2.Explanation = "Diyarbakır";

Product[] products= new Product[] { product1, product2 };

foreach(Product product in products)
{

    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Explanation);
    Console.WriteLine("------------------");
}
Console.WriteLine("---------Methods---------------");

//instance
SepetManager sepetManager = new SepetManager();
sepetManager.Add(product1);
sepetManager.Add(product2);




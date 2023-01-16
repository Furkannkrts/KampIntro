// See https://aka.ms/new-console-template for more information
using ClassMetodDemo;



Musteri musteri1 = new Musteri
{
    Id = 1,
    Name = "Furkan",
    Surname = "KARATAS",
    BirthDate= DateTime.Parse("12.12.1222"),
};
Musteri musteri2 = new Musteri
{
    Id = 2,
    Name = "Emre",
    Surname = "ISIK",
    BirthDate = DateTime.Parse("12.12.1222"),
};

//String constantFormat = "dddd, dd MMMM yyyy HH:mm";

//String dateExample =  DateTime.Now.ToString(constantFormat);

List<Musteri> musteriler = new List<Musteri>();

MusteriManager result = new MusteriManager();

musteriler = result.Ekle(musteri1, musteriler);
Console.WriteLine("1. musteri eklendi");
musteriler = result.Ekle(musteri2, musteriler);
Console.WriteLine("2. musteri eklendi");
musteriler = result.Sil(musteriler, musteri1.Id);
Console.WriteLine("musteri 1 sílindi");
result.Listele(musteriler);



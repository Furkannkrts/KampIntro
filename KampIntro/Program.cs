// See https://aka.ms/new-console-template for more information
string kategoriEtiketi = "Kategoriler";
int ogrencisayisi = 3500;
double faizorani = 1.45;
bool sistemegirisYapmisMi=true;
double dolardun = 7.45;
double dolarbugun = 7.45;


if (dolardun>dolarbugun)
{
    Console.WriteLine("azalış butonu");

}

else if (dolardun<dolarbugun)
{
    Console.WriteLine("artış butonu");

}
else
{
    Console.WriteLine("eşittir butonu"); 
}


if(sistemegirisYapmisMi==true) 
{
    Console.WriteLine("Kullanici ayarları butonu");


}
else
{
    Console.WriteLine("giris yap butonu");
}
 
Console.WriteLine(kategoriEtiketi);



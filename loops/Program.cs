// See https://aka.ms/new-console-template for more information


string kurs1 = "Yazılım Geliştici Kursu";
string kurs2 = "Pyhthon";
string kurs3 = "Java";


string[]kurslar  = new string[] { "Yazılım Geliştici Kursu", "Pyhthon", "Java" ,"C++"};




for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);

}

Console.WriteLine("for bitti");
foreach (string kurs in kurslar) 
{
    Console.WriteLine(kurs);   
}

Console.WriteLine();
Console.WriteLine("sayfaa sonu");

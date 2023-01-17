// See https://aka.ms/new-console-template for more information


Kurs kurs1 = new Kurs();
kurs1.egitmen = "Furkan Karataş";
kurs1.izlenmeOrani = 68;
kurs1.kursAdi = "C#";

Kurs kurs2 = new Kurs();
kurs2.egitmen = "Hayri Barut";
kurs2.izlenmeOrani = 70;
kurs2.kursAdi = "Java";

Kurs kurs3 = new Kurs();
kurs3.egitmen = "Emre Işık";
kurs3.izlenmeOrani = 72;
kurs3.kursAdi = "Python";

Kurs kurs4 = new Kurs();
kurs4.egitmen = "Barış Yarkadaş";
kurs4.izlenmeOrani = 90;
kurs4.kursAdi = "SQL";


Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

foreach (Kurs kurs in kurslar)
{
    Console.WriteLine(kurs.kursAdi+":"+kurs.egitmen);
}




class kurs
{
    public string kursadi { get; set; }
    public string egitmen { get; set; }
    public int izlenmeorani { get; set; }


}
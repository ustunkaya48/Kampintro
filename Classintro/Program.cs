// See https://aka.ms/new-console-template for more information
string adi = "ustun";
int yasi = 45;

Kurs kurs1 = new Kurs();  //kurs1 adında bir class tanımladık. Tipi Kurs yani birden fazla eleman içeriyor
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demirog";  //Kurs class'ının değerlerini atadık
kurs1.izlenmeOrani = 80;

Kurs kurs2 = new Kurs();  
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Kerem Varış";  
kurs2.izlenmeOrani = 80;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Berkay Bilgin";
kurs3.izlenmeOrani = 80;


//Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3}; //Daha önce string türünde tanımladığımız diziyi Kurs adında class'la tanımladık

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
}

class Kurs   //Class tanımladık
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int izlenmeOrani { get; set; }
}

// See https://aka.ms/new-console-template for more information

using Metodlar;

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2=new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] {urun1,urun2};  //Urun class'ından array oluşturduk. Dizinin ismi urunler

//C# type safe - tip güvenli bir dil olduğu için veri tipini bilmek ister, o yüzden (Urun) 
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati); 
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("--------------------------");
}
Console.WriteLine("--------------Metodlar----------------");
//instance - örnek
//encapsulation
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut","Yeşil armut",12);
sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 25);


//Dont repeat yourself - DRY - Clean code - Best Practise

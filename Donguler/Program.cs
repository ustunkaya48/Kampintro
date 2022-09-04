// See https://aka.ms/new-console-template for more information

string kurs1 = "Yazılım Geliştirme Kampı";
string kurs2 = "Java kursu";
string kurs3 = "Temel Programlamaya Giriş";

//array - dizi

string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Java kursu", "Temel Programlamaya Giriş","Python","C#","PHP" };

for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("For Bitti!");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}
//foreach - dizi temelli yapıları tek tek döndürür
Console.WriteLine("Sayfa Sonu");

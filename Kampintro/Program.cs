﻿// See https://aka.ms/new-console-template for more information
//type safety - tip güvenliği
//Do not repeat yourself - Kendini tekrarlama
//kategoriEtiketi-- bir değer tutucu-alias(takma isim)
string kategoriEtiketi = "Kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi=true;
double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("Eşittir Butonu");
}

if (sistemeGirisYapmisMi==true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}

Console.WriteLine(kategoriEtiketi);

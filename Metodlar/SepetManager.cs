using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun) //Bu parantezler varsa bir metod/fonksiyon çalışıyordur.Metoda parametre verdik. Urun(tip),urun(isimlendirme)
        {
            Console.WriteLine("Tebrikler..Sepete Eklendi! : " + urun.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat)//Yanlış kullanım.Herhangi bir veri değiştiğinde diğer sayfalar da değişir
        {
            Console.WriteLine("Tebrikler..Sepete Eklendi! : " + urunAdi);
        }
    }
}

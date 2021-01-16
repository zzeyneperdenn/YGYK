using System;

namespace YGYK2
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip guvenligi
            //do not repeat yourself
            //kategoriEtiketi = alias = deger tutucu
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici Ayalarlari Butonu");
            }
            else
            {
                Console.WriteLine("Sisteme Giris Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}

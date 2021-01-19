using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Zeynep";
            musteri1.Surname = "Erden";
            musteri1.Password = 1234;
            musteri1.Money = 987654.32;
            musteri1.Address = "Bahcelievler, Istanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Engin";
            musteri2.Surname = "Demirog";
            musteri2.Password = 4567;
            musteri2.Money = 123456.98;
            musteri2.Address = "Bostanci, Istanbul";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Ali";
            musteri3.Surname = "Coban";
            musteri3.Password = 9876;
            musteri3.Money = 569874.32;
            musteri3.Address = "Iskenderun, Hatay";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("");

            musteriManager.List(musteriler);
            Console.WriteLine("");

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
        }
    }
}

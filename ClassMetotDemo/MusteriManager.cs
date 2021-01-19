using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler! Musteri Eklendi: " + musteri.Name + " " + musteri.Surname);
        }
        public void List(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id.ToString() + " " + musteri.Name + " " + musteri.Surname + " " + musteri.Password + musteri.Money + " " + musteri.Address);
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi: " + musteri.Name + " " + musteri.Surname);
        }
    }
}

using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = ?
            Console.WriteLine(sayi1);
            //sayi1 = 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = ?
            Console.WriteLine(sayilar1[0]);
            //sayilar1[0] = 999


            //deger tipler: int, decimal, float, double, bool
            //referans tipler: array, class, interface

            //stack ve heap 

            //stack: sayi1 = X10X 30. sayi2 = X30X 65

            //new demek heap'te yer olustur demek
            //stack: sayilar1 - heap: 10, 20, 30
            //stack: sayilar2 - heap: X100X 999, 200, 300
        }
    }
}

using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "YGYK";
            string kurs2 = "PBİTK";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array = dizi

            string[] kurslar = new string[] { "YGYK", "PBİTK", "Java", "Python", "C++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti.");

            foreach (string kurs in kurslar) //dizi temelli yapilari tek tek gormeye yariyor. kuslari dolas demek bu
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");


            for (int i = 1; i < 10; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}

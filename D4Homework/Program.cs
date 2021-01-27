using System;

namespace D4Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(0, "Zeynep");
            myDictionary.Add(1, "Zeliha");
            myDictionary.Add(2, "İlayda");
            myDictionary.Add(3, "Hilal");
            myDictionary.Add(4, "Kubra");
            Console.WriteLine(myDictionary.Count);

            foreach (var my in myDictionary.Item1)
            {
                Console.WriteLine(my);
            }

            foreach (var my in myDictionary.Item2)
            {
                Console.WriteLine(my);
            }
        }
    }
}

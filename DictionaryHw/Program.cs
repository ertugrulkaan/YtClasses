using System;
using System.Collections.Generic;

namespace DictionaryHw
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cityList = new MyDictionary<int, string>();
            cityList.Add(1, "Adana");
            cityList.Add(6, "Ankara");
            cityList.Add(34, "Istanbul");
            cityList.Add(34, "Istanbul");


            Console.WriteLine("Sozlukteki eleman sayisi : " + cityList.Count);
            Console.WriteLine("----------------------------------");

            // Anahtarlar
            foreach (var key in cityList.Keys)
            {
                Console.Write("Anahtar = "+ key);
                foreach (var value in cityList.Values)
                {
                    Console.Write("  Degeri = " + value);
                }
                Console.WriteLine("----------------------------------");
            }



        }
    }
}

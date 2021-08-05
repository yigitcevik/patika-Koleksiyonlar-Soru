using System;
using System.Collections;
using System.Collections.Generic;

namespace KoleksiyonlarSoru3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sesli = "aeıioöuü";
            Console.WriteLine("Metin giriniz.");
            string metin = Console.ReadLine();
            ArrayList sesliHarfler = new ArrayList();

            for (int i = 0; i < metin.Length; i++)
            {
                if (sesli.Contains(metin[i]))
                {
                    sesliHarfler.Add(metin[i]);
                    //Console.Write(sesliHarfler);
                }
            }
            sesliHarfler.Sort();
            foreach (var item in sesliHarfler)
            {
                Console.Write(item);
            }            
        }
    }
}

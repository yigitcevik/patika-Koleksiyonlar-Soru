using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar-Soru-1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, bolunme = 0;
            int b = a;
            ArrayList asal = new ArrayList();
            ArrayList asalDegil = new ArrayList();
            for (int i = 0; i < a; i++)
            {
                Console.Write("{0} adet pozitif sayı giriniz: ", b);
                int n = 0;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (n >= 0)
                    {
                        for (int j = 2; j < n; j++)
                        {
                            if (n % j == 0) bolunme++;
                        }
                        if (bolunme > 0) asalDegil.Add(n);
                        else asal.Add(n);
                        bolunme = 0;
                        b--;
                    }
                    else error(i);
                }
                else error(i);
            }
            ortalama(asal, asalDegil);
        }

        public static int error(int i)
        {
            Console.WriteLine("Sadece pozitif sayı girebilirsiniz.");
            return i--;
        }

        public static void ortalama(ArrayList asal, ArrayList asalDegil)
        {
            float asalOrt = 0, asalDegOrt = 0;
            foreach (int item in asal)
            {
                asalOrt += item;
            }
            foreach (int item in asalDegil)
            {
                asalDegOrt += item;
            }
            asalOrt /= asal.Count;
            asalDegOrt /= asalDegil.Count;

            Console.WriteLine("Asal ortalama: " + asalOrt);
            Console.WriteLine("Asal olmayanlar ortalama: " + asalDegOrt);

            Console.WriteLine("Asal Olanlar");
            foreach (var item in asal)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nAsal Olmayanlar");
            foreach (var item in asalDegil)
            {
                Console.Write(item + " ");
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace KoleksiyonlarSoru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = a;
            float ortalama1 = 0, ortalama2 = 0;
            ArrayList tumSayilar = new ArrayList();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("{0} adet sayı giriniz: ", b);
                tumSayilar.Add(int.Parse(Console.ReadLine()));
                b--;
            }

            tumSayilar.Sort();
            for (int i = 0; i < 3; i++)
            {
                ortalama1 += Convert.ToInt32(tumSayilar[i]);
            }
            Console.WriteLine("Küçük sayıların ortalaması: " + ortalama1/3);
            tumSayilar.Reverse();
            for (int i = 0; i < 3; i++)
            {
                ortalama2 += Convert.ToInt32(tumSayilar[i]);
            }
            Console.WriteLine("Büyük sayıların ortalaması: " + ortalama2/3);
            float toplam = (ortalama1/3) + (ortalama2/3);
            Console.WriteLine("Ortalama toplamları: " + toplam);
            
        }
    }
}

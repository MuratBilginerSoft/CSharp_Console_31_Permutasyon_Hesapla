using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Permutasyon_Hesapla
{
    class Program
    {
        static int Faktoriyel(int x)
        {
            int carpim = 1;

            for (int i = 1; i <= x; i++)
            {
                carpim *= i;
            }
            return carpim;
        }

        static int Permutasyon(int a, int b)
        {
            int sonuc;

            sonuc = Faktoriyel(a) / Faktoriyel(a - b);

            return sonuc;
        }

        static void Main(string[] args)
        {
            int a, b;

            Console.Write("n Değerini Giriniz:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("r Değerini Giriniz:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("P("+a+","+b+")="+Permutasyon(a, b));

            Console.ReadKey();
        }
    }
}

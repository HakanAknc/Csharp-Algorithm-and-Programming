using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmatik_Dort_Islem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aritmatik 4 işlem Uygulaması

            int s1, s2, toplam, carpim, bolum, fark;

            Console.WriteLine("***** Aritmatik İşlemler *****");
            Console.WriteLine();
            s1 = 20;
            s2 = 5;
            toplam = s1 + s2;
            carpim = s1 * s2;
            bolum = s1 / s2;
            fark = s1 - s2;
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Çarpım: " + carpim);
            Console.WriteLine("Bölüm: " + bolum);
            Console.WriteLine("Fark: " + fark);
            Console.WriteLine();
            Console.WriteLine("***** Aritmatik İşlemler *****");

            Console.Read();
        }
    }
}

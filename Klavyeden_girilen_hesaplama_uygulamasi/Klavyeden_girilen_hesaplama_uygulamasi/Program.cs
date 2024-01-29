using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_girilen_hesaplama_uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen diktörgenin alan ve çevresini hesaplama
            // alan => a*b     cevre => 2(a*b)
            /*
            int a, b, alan, cevre;
            Console.Write("a değerini giriniz: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("b değerini giriniz: ");
            b = Convert.ToInt16(Console.ReadLine());
            alan = a * b;
            cevre = 2*(a + b);

            Console.WriteLine("Alan: " + alan);
            Console.WriteLine("Çevre: " + cevre);
            
            Console.Read();
            */


            // Klavyeden girilen Aritmatik dört işlem uygulan kodu yaz

            int s1, s2, toplam, carp, bolum, fark;

            Console.Write("Sayı 1: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayı 2: ");
            s2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            toplam = s1 + s2;
            carp = s1 * s2;
            bolum = s1 / s2;
            fark = s1 - s2;
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Çarpım: " +  carp);
            Console.WriteLine("Bölüm: " +  bolum);
            Console.WriteLine("Fark: " +  fark);

            Console.Read();
        }
    }
}

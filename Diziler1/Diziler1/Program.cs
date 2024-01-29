using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "adana", "ankara", "bursa", "antalya", "istanbul" };
            //Console.WriteLine("Dizimizin 2.index değeri: "+ sehirler[2]);
            //Console.WriteLine(sehirler[0]);
            //Console.WriteLine(sehirler[1]);
            //Console.WriteLine(sehirler[2]);
            //Console.WriteLine(sehirler[3]);
            //Console.WriteLine(sehirler[4]);

            //Console.WriteLine(sehirler[5]);   -> Hata


            // Int değişkenler ile dizi kullanımı
            /*
            Console.WriteLine("Int değişkenker ile dizi kullanımı");
            Console.WriteLine();
            int[] sayilar = { 10, 20, 30, 40, 50, 60 };
            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar[1]);

            for (int i = 0; i < sayilar.Length; i++)        // Length => uzunluk
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.Read();
            */


            // Dizilerde toplama işlemi

            Console.WriteLine("Dizilerde toplama işlemi örneği");
            Console.WriteLine();

            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
                Console.WriteLine(toplam);
            }
            Console.Read();s
        }
    }
}

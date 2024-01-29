using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Metotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sort metotu
            /*
            int[] sayilar = { 20, 14, 12, 35, 13 };
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.Read();
            */


            // Reverse metotu
            /*
            string[] sehirler = { "Adana", "Ankara", "Zonguladak", "Malatya", "Elazığ", "Bursa" };
            Array.Reverse(sehirler);
            //Array.Sort(sehirler);

            for (int i = 0; i < sehirler.Length;  i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.Read();
            */


            // Index Of metot
            /*
            string[] kisiler = { "Buse", "Ali", "Hakan", "Furkan", "Eylü" };
            int sira;
            sira = Array.IndexOf(kisiler, "Hakan");
            Console.WriteLine(sira);
            Console.Read();
            */


            // Max - Min metot
            int[] sayilar = { 76, 43, 12, 56, 34 };
            Console.WriteLine("En küçük sayi: " + sayilar.Min());
            Console.WriteLine("En büyük sayi: " + sayilar.Max());
            Console.Read();
        }
    }
}

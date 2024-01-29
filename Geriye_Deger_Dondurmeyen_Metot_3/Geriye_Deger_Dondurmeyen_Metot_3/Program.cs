using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geriye_Deger_Dondurmeyen_Metot_3
{
    internal class Program
    {
        public static void MetinYaz(string p)
        {
            Console.Write("**********");
            Console.WriteLine();
            Console.Write(p);
            Console.WriteLine();
            Console.WriteLine("**********");
        }

        public static void MetinYaz2(string parametre)
        {
            Console.Write("----------");
            Console.WriteLine();
            Console.Write(parametre);
            Console.WriteLine();
            Console.Write("----------");
        }
        static void Main(string[] args)
        {
            // Geriye değer döndürmeyen metotlara dışarıdan nasıl parametre gönderileceğine dair uygulama
            Console.Write("Kelimeyi giriniz: ");
            string kelime = Console.ReadLine();

            // void metotlarda parametre kullanımı
            MetinYaz("Merhaba Dünya!");

            MetinYaz2(kelime);

            Console.Read();
        }
    }
}

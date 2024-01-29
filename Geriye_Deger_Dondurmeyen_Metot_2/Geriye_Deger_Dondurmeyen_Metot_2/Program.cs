using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geriye_Deger_Dondurmeyen_Metot_2
{
    internal class Program
    {
        public static void yazdir()
        {
            Console.Write("Bu bir metottur.");
            Console.WriteLine();
            Console.Write("Bu da başka bir metottur.");
            Console.WriteLine();
        }

        public static void toplamametodu()
        {
            int sayi1 = 24, sayi2 = 25;
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);
        }

        public static void yazibosluk()
        {
            Console.WriteLine("");
            Console.Write("*********************");
            Console.WriteLine();
        }

        public static void ardisiksayilar()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
        static void Main(string[] args)
        {
            yazdir();
            //Console.WriteLine("******************");
            //Console.WriteLine();
            yazibosluk();
            yazdir();
            //Console.WriteLine("******************");
            yazibosluk();
            toplamametodu();
            yazibosluk();
            ardisiksayilar();
            Console.Read();        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Sayinin_Karesini_Alma_Metot
{
    internal class Program
    {
        static int KareAl(int a)
        {
            return a * a;
        }
        static void Main(string[] args)
        {
            // Kullanıcıdan aldığmız sayının karesini alalım eğer karesi 25'ten büyükse
            // 25'ten büyükse büyüktür yazdırsın.
            // 25'ten küçükse küçüktür yazdırsın

            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int KareDeger = KareAl(sayi);

            if (KareDeger > 25)
            {
                Console.WriteLine("Karesi 25'ten büyüktür.");
            }
            else
            {
                Console.WriteLine("Karesi 25'ten küçüktür");
            }
            Console.Read();

        }
    }
}

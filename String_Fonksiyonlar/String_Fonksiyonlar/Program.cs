using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Fonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin1, metin2;
            Console.Write("Metin1 giriniz: ");
            metin1 = Console.ReadLine();
            Console.Write("Metin2 giriniz: ");
            metin2 = Console.ReadLine();

            Console.WriteLine("Concat ile birleştirme: " + string.Concat(metin1, metin2));
            Console.WriteLine("Metin1 için karektet sayısı: " +  metin1.Length);
            Console.WriteLine("IndexOf örenği: " + metin1.IndexOf("aydın"));
            Console.WriteLine("Startswith örenği: " + metin1.StartsWith("merhaba"));
            Console.WriteLine("Merhaba Dünya: " + metin1.Trim());
            Console.WriteLine("Büyük harf: " + metin1.ToUpper());
            Console.WriteLine("Küçük harf: " + metin1.ToLower());
            Console.WriteLine("Remove metodu: " + metin1.Remove(4));
            Console.WriteLine("Replaca fonksiyonu: " + metin1.Replace("a","A"));
            Console.WriteLine("Substring metodu: " + metin1.Substring(4));

            Console.ReadLine();
        }
    }
}

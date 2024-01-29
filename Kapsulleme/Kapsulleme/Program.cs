using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Müşteri Sınıfı
            Musteri m = new Musteri();

            Console.Write("ID değerini giriniz: ");
            m.id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adınız: ");
            m.Ad = Console.ReadLine();

            Console.Write("Soyadınız: ");
            m.Soyad = Console.ReadLine();

            Console.Write("Şehir: ");
            m.sehir = Console.ReadLine();

            Console.Write("***** Müşteri Kimlik Kartı *****");
            Console.WriteLine();
            Console.WriteLine(m.id + "-" + m.Ad + " " + m.Soyad + " " + m.sehir);

            Console.Read();
        }
    }
}

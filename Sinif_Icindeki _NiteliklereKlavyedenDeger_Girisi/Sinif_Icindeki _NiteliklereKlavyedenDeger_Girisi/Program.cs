using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Icindeki__NiteliklereKlavyedenDeger_Girisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Müşteri Sınıfı
            Musteri m = new Musteri();

            Console.Write("ID değerini giriniz: ");
            m.id = Convert .ToInt32(Console.ReadLine());

            Console.Write("Adınız: ");
            m.ad = Console.ReadLine();

            Console.Write("Soyadınız: ");
            m.soyad = Console.ReadLine();

            Console.Write("Şehriniz: ");
            m.sehir = Console.ReadLine();

            Console.WriteLine("***** Müşteri Bilgisi *****");
            Console.WriteLine();
            Console.Write(m.id + "-" + "Ad Soyad: " + m.ad + " " + m.soyad + " " + m.sehir);
            Console.WriteLine();
            Console.WriteLine();


            // Araba Sınıfı
            Araba a = new Araba();

            Console.Write("Araba marka'sını giriniz: ");
            a.marka = Console.ReadLine();

            Console.Write("Araba model'ini giriniz: ");
            a.model = Console.ReadLine();

            Console.Write("Araba reng'ini giriniz: ");
            a.renk = Console.ReadLine();

            Console.Write("Araba hız'ını giriniz: ");
            a.hiz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Araba motor'unu giriniz: ");
            a.motor = double.Parse(Console.ReadLine());

            Console.WriteLine("***** Araba İstek Formu *****");
            Console.WriteLine();
            Console.WriteLine("Marka: " + a.marka);
            Console.WriteLine("Model: " + a.model);
            Console.WriteLine("Renk: " + a.renk);
            Console.WriteLine("Hız: " + a.hiz);
            Console.WriteLine("Motor: " + a.motor);
            Console.Read();
        }
    }
}

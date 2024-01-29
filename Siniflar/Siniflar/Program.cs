using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Araba Sınıfı
            Araba ar = new Araba();
            ar.marka = "Togg Sedan";
            ar.model = "2021";
            ar.hiz = 500;
            ar.renk = "Siyah";
            ar.motor = 4.8;

            Console.Write("***** Araba Tanıtım Kartı 1 *****");
            Console.WriteLine();
            Console.WriteLine("Marka: " + ar.marka);
            Console.WriteLine("Model: " + ar.model);
            Console.WriteLine("Hız: " + ar.hiz);
            Console.WriteLine("Renk: " + ar.renk);
            Console.WriteLine("Motor: " + ar.motor);
            Console.WriteLine();


            // Müşteri Sınıfı
            Musteri m = new Musteri();
            m.id = 1;
            m.ad = "Hakan";
            m.soyad = "Akıncı";
            m.sehir = "Konya";

            Console.Write("***** Müşteri Tanıtım Kartı *****");
            Console.WriteLine();
            Console.Write(m.id + "-" + "Ad Soyad: " + m.ad + " " + m.soyad + " Şehir: " + m.sehir);
            Console.WriteLine();

            m.id = 2;
            m.ad = "Muhammed Atıf";
            m.soyad = "Bistami";
            m.sehir = "Hatay";

            Console.WriteLine();
            Console.Write(m.id + "-" + "Ad Soyad: " + m.ad + " " + m.soyad + " Şehir: " + m.sehir);
            Console.WriteLine();

            Console.Read();

        }
    }
}

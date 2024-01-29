using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarih_Zaman_Fonksiyonlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datetime
            Console.WriteLine("Bugünün gün bilgisi: " + DateTime.Now);
            Console.WriteLine("Bugünün ay bilgisi: " + DateTime.Now.Month);
            Console.WriteLine("Bugünün yıl bilgisi: " + DateTime.Now.Year);
            Console.WriteLine("Bugünün saat bilgisi: " + DateTime.Now.Hour);
            Console.WriteLine("Bugünün dakika bilgisi: " + DateTime.Now.Minute);
            Console.WriteLine("Bugünün saniye bilgisi: " + DateTime.Now.Second);
            Console.WriteLine("Bugünün kısa tarih bilgisi: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Bugünün uzun tarih bilgisi: " + DateTime.Now.ToLongDateString());

            Console.WriteLine();

            // Time span
            TimeSpan zaman;
            int gunfarki;
            DateTime tarih1, tarih2;
            tarih1 = Convert.ToDateTime("20.10.2001");
            tarih2 = Convert.ToDateTime("28.01.2024");
            zaman = tarih2 - tarih1;
            gunfarki = zaman.Days;
            Console.WriteLine("Fark: " +  gunfarki);


            Console.Read();
        }
    }
}

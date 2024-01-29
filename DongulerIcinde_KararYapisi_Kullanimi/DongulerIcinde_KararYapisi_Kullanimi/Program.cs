using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongulerIcinde_KararYapisi_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -> Sayının tek mi çift mi olduğunu kontrol eden kod
            /*
            int sayi;
            Console.Write("Sayı giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());

            if (sayi % 2 == 0 )
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }
            Console.Read();
            */

            // -> 20'ye kadar olan sayıların 3'e tam bölünüp bölünmediğini konrol edeb program
            /*
            for (int j = 1; j <= 20;  j++)
            {
                if (j % 3 == 0)
                {
                    Console.WriteLine(j);
                }
            }
            Console.Read();
            */


            // -> Tam bölenleri bulan program?
            /*
            int sayi;
            Console.Write("Sayı giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
            */


            // -> Faktöriyel hesaplama
            /*
            int faktıriyel = 1;
            for (int i = 5; i>=1; i--)
            {
                faktıriyel = faktıriyel * i;
                Console.WriteLine(faktıriyel);
            }
            Console.Read();
            */

            int faktoriyel = 1;
            Console.Write("Sayi girinzi: ");
            int sayi = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
                Console.WriteLine(faktoriyel);
            }
            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] sehirler = { "Ankara", "Adana", "Bursa", "İzmir" };
            foreach (string s in sehirler)
            {
                Console.WriteLine(s);
            }
            Console.Read();
            */


            // Foreach ile Aritmatik İşlemler
            /*
            Console.WriteLine("Foreach ile Aritmatik İşlemler");
            int[] sayilar = { 26, 55, 32, 16, 89, 70 };
            int toplam = 0;

            foreach (int q in sayilar)
            {
                toplam = q + toplam;
                //Console.WriteLine(toplam);
            }
            Console.WriteLine("Toplam: " + toplam);
            Console.Read();
            */


            // Diziye Klavyeden Değer Girişi

            string[] sehirler = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Şehir ismi: ");
                sehirler[i] = Console.ReadLine();
            }
            
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(sehirler[j]);
            }
            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayinin_TekCift__Kontrolu_Metot
{
    internal class Program
    {
        static void TekCiftKontrol(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }
        }
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan sayının tek mi çift mi olduğunu konteol etme

            Console.WriteLine("Bir sayı giriniz: ");
            int deger = int.Parse(Console.ReadLine());

            TekCiftKontrol(deger);

            Console.Read();
        }
    }
}

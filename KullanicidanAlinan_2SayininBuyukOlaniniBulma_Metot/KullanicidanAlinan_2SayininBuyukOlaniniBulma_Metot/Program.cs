using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanAlinan_2SayininBuyukOlaniniBulma_Metot
{
    internal class Program
    {
        static void KontrolEt(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("a sayısı büyüktür.");
            }
            else if (a == b)
            {
                Console.WriteLine("a ve b birbirine eşittir.");
            }
            else
            {
                Console.WriteLine("b sayısı büyüktür.");
            }
        }
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan iki sayıdan büyük olanı bulan program

            Console.Write("a sayısını giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("b sayısını giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            KontrolEt(sayi1, sayi2);

            Console.Read();
        }
    }
}

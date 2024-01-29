﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının giridiği sayı dizinin içinde var mı? varsa kçata olduğunu yazan yoksa da yoktur yazan program?

            int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 40, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 };
            int adet = 0;
            int sayi;

            Console.Write("Lütfen bir sayı giriniz: ");

            sayi = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
            }
            if (adet == 0)
            {
                Console.WriteLine("Girdiğiniz değer dizide bulunamadı...");
            }
            else
            {
                Console.WriteLine("Girdiğiniz değer dizide bulundu.");
                Console.Write("Adet: " +  adet);
            }
            Console.Read();
        }
    }
}

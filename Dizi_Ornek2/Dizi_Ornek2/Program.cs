using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 10 tane değer alan ve şu işlemleri uygulana programı yazınız...
            // 1-) Kaç adet tek, çift elman olduğunu
            // 2-) Çift değerlerin toplamı, tek değerlerin toplamı
            // 3-) Son olarak kontol yapısını Çift değerlerin toplamı, tek değerlerden büyükse Çift değerler büyüktür yazsın.
            //     eğer tek değerlerin toplamı büyükse tek değerler büyüktür yazsın.

            int[] sayilar = new int[10];

            int tekAdetToplami = 0;
            int ciftAdetToplami = 0;

            int tekSayilarinToplami = 0;
            int cifrSayilarinToplami = 0;

            int kullaniciDeger;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 0) + ".index değerini giriniz: ");
                kullaniciDeger = int.Parse(Console.ReadLine());

                sayilar[i] = kullaniciDeger;
            }

            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j]%2==0)
                {
                    ciftAdetToplami++;
                    cifrSayilarinToplami += sayilar[j];
                }
                else
                {
                    tekAdetToplami++;
                    tekSayilarinToplami += sayilar[j];
                }
            }

            if (cifrSayilarinToplami > tekSayilarinToplami)
            {
                Console.WriteLine("Çift sayıların toplamı tek sayıların toplamından büyüktür.");
            }
            else
            {
                Console.WriteLine("Tek sayıların toplamı çift sayıların toplamından büyüktür.");
            }

            Console.WriteLine("**************************************************************");

            Console.WriteLine("Çift sayıların toplamı: " + cifrSayilarinToplami);
            Console.WriteLine("Tek sayıların toplamı: " + tekSayilarinToplami);

            Console.Read();
        }
    }
}

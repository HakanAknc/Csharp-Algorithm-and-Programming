using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Bir tane öğrencimiz olucak, öğrencinin; öğrenciNo, isim, soyisim, vize1, vize2, fianl, okunİsim adında değişkeneri olucak
            erişim belirleyicileri private yapıcağız. Yapıcı metot kullanarak değişkenlere değereleri atıyacağız.

            ogrenciBilgiGoster() metodu oluacak öğrencinin bilgilerini görebileceğiz
            ogrenciOrtalamasiBul() metodu olucak
            okulGetir() metodu olucak.

            Ogrencinin seçimine göre işlemler yapacağız:
            1- Ogrenci bilgi göster.
            2- Ogrenci ortalama göster.
            3- Ogrencinin okulunu öğren.
            7- Çıkş yap
             */

            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(1, "Hakan", "Akıncı", 75, 65, 70, "Necmettin Erbakan Üniversitesi");

            Console.WriteLine("***** Öğrenci Bilgi Sistemine Hoşgeldiniz *****");
            Console.WriteLine("***** Yapamak İstediğiniz İşlemi Seçiniz  *****");
            Console.WriteLine();


            while (kontrol)
            {
                IslemleriGoster();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":

                        ogrenci1.OgrenciBilgiGoster();
                        break;

                    case "2":

                        double ogrenciOrtalama = ogrenci1.OgrenciNotuHesapla();
                        Console.WriteLine("Öğrencinin Ortalaması: " +  ogrenciOrtalama);
                        break;

                    case "3":

                        ogrenci1.okulGetir();
                        break;

                    case "4":

                        kontrol = false;
                        break;
                }
            }


        }

        static void IslemleriGoster()
        {
            Console.WriteLine("1- Öğrenci Bilgileri Göster: ");
            Console.WriteLine("2- Öğreci Ortalamasını Göster: ");
            Console.WriteLine("3- Öğrenci Okulunu Göster: ");
            Console.WriteLine("4- Çıkış: ");
            Console.WriteLine() ;
            Console.Write("İşlem: ");
        }

    }
}

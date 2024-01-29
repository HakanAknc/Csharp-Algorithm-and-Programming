using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kitaplik_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat = 0;
            string secim;
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***  Türkçe Kitaplar Kategorisi         ***  Yabancı Kitaplar Kategorisi              ***");
            Console.WriteLine();
            Console.WriteLine("***  1-Çalıkuşu : Reşat Nuri            ***  7-Tuna Klavuzu : Jules Verne             ***");
            Console.WriteLine();
            Console.WriteLine("***  2-Yaban : Yakup Kadri              ***  8-Bir Kuzey Macerası : Jack Landon       ***");
            Console.WriteLine();
            Console.WriteLine("***  3-Sinekli Bakal : Halide Edip      ***  9-Altıncı Koğuş : Anton Çehov            ***");
            Console.WriteLine();
            Console.WriteLine("***  4-Tehlikeli Oyunlar : Oğuz Atay    ***  10-Kumarbaz : Dostoyevski                ***");
            Console.WriteLine();
            Console.WriteLine("***  5-Geçtiğim Günlerden : Hasan Yücel ***  11-İki Şehrin Hikayesi : Charles Dickens ***");
            Console.WriteLine();
            Console.WriteLine("***  6-Kuyucaklı Yusuf : Sabahattin Ali ***  12-Vişne Bahçesi : Anton Çehov           ***");
            Console.WriteLine();
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine();

            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemin numarası: ");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == '1')
            {
                Console.WriteLine();
                Console.Write("Lütfen öğrenmek istediğniz kitabın numarasını giriniz: ");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.WriteLine("Çalıkuşu 12 TL"); break;
                    case "2": Console.WriteLine("Yaban 14 TL"); break;
                    case "3": Console.WriteLine("Sinekli Bakal 16 TL"); break;
                    case "4": Console.WriteLine("Tehlikeli Oyunlar 11 TL"); break;
                    case "5": Console.WriteLine("Geçtiğim Günlerden 8 TL"); break;
                    case "6": Console.WriteLine("Kuyucaklı Yusuf 13 TL"); break;
                    case "7": Console.WriteLine("Tuna Klavuzu 17 TL"); break;
                    case "8": Console.WriteLine("Bir Kuzey Macerası 4 TL"); break;
                    case "9": Console.WriteLine("Altıncı Koğuş 5 TL"); break;
                    case "10": Console.WriteLine("Kumarbaz 10 TL"); break;
                    case "11": Console.WriteLine("İki Şehrin Hikayesi 13 TL"); break;
                    case "12": Console.WriteLine("Vişne Bahçesi 6 TL"); break;
                    default: Console.Write("Böyle bir kitap mevcut değil, numaryı kontrol edin."); break;
                }
            }
            if (islem == '2')
            {
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.Write("Adınız: ");
                ad = Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad = Console.ReadLine();
                Console.Write("Üniversiteniz: ");
                universite = Console.ReadLine();

                string dosya = @"C:\Users\Hakan Akıncı\Desktop\kullanici.txt";   // dosyanın konumu
                StreamWriter sw = new StreamWriter(dosya);  //obje oluşturuldu  StreamWriter = dosyaya yazdırma işlemi yapar
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: " +  soyad);
                sw.WriteLine("Üniversiteniz: " +  universite);
                sw.Close();
            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("*************************************************");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("------ ==>  Bugünün Kitabı : Çalıkuşu  <== ------");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("*************************************************");
            }
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("*************************************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\Hakan Akıncı\Desktop\kitaplar.txt", FileMode.Open,FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while (metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                //burası kitap arşivi olucak
                Console.WriteLine();
                Console.WriteLine("*************************************************");
                Console.WriteLine();
            }
            if (islem == '5')
            {
                for(int i = 0; i < 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız kitabın numarası: ");
                    secim = Console.ReadLine();
                    if(secim == "1")
                    {
                        toplamfiyat = toplamfiyat + 12;
                    }
                    else if(secim == "2")
                    {
                        toplamfiyat = toplamfiyat + 14;
                    }
                    else if (secim == "3")
                    {
                        toplamfiyat = toplamfiyat + 16;
                    }
                    else if (secim == "4")
                    {
                        toplamfiyat = toplamfiyat + 11;
                    }
                    else if (secim == "5")
                    {
                        toplamfiyat = toplamfiyat + 8;
                    }
                    else if (secim == "6")
                    {
                        toplamfiyat = toplamfiyat + 13;
                    }
                    else if (secim == "7")
                    {
                        toplamfiyat = toplamfiyat + 17;
                    }
                    else if (secim == "8")
                    {
                        toplamfiyat = toplamfiyat + 4;
                    }
                    else if (secim == "9")
                    {
                        toplamfiyat = toplamfiyat + 5;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat = toplamfiyat + 10;
                    }
                    else if (secim == "11")
                    {
                        toplamfiyat = toplamfiyat + 13;
                    }
                    else if (secim == "12")
                    {
                        toplamfiyat = toplamfiyat + 6;
                    }
                    else
                    
                        Console.WriteLine("Böyle bir kitap numarası yok");
                        Console.WriteLine();
                        Console.Write("Başka bir kitap almak istiyormusunuz: ");
                        string cevap = Console.ReadLine();
                        if (cevap == "h" || cevap == "H" || cevap == "hayır" || cevap == "HAYIR")
                            break;
                }
                Console.WriteLine("Toplam Tutar: " + toplamfiyat);
            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                while (sayi != tahmin)
                {
                    Console.Write("Sayı giriniz: ");
                    tahmin = Convert.ToInt16(Console.ReadLine());
                    if (tahmin > sayi)
                    {
                        Console.WriteLine("Daha küçük bir sayı giriniz.");
                    }
                    if (tahmin < sayi)
                    {
                        Console.WriteLine("Daha büyük bir sayı giriniz.");
                    }
                    if (tahmin == sayi)
                    {
                        Console.WriteLine("Bildiniz :)");
                        break;
                    }
                }
            }

            Console.Read();
        }
    }
}

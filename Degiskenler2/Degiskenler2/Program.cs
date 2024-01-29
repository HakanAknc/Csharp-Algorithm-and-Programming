using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden Veri Girişi
            // ReadLine() => Kullanıcıdan alınan metinsel ifadeyi hafızada tutar. Tür: String
            // ReadKey() => Klavyeden basılan tuşun bilgisini verir.
            // Read() => Girilen parametrenin sadece ilk karekterinin ascii karşılığını verir.
            /*
            string sehir, ilce;
            Console.Write("Lütfen şehrinizi giriniz: ");
            sehir = Console.ReadLine();
            Console.Write("Lütfen ilçenizi giriniz: ");
            ilce = Console.ReadLine();
            Console.WriteLine("Girdiğiniz şehir: " +  sehir + "-" + ilce);
            */


            // ************* DÖNÜŞÜMLER  **************
            // Dönüşüm için ANAHTAR kelime =====> "Convert"

            // Int Dönüşümü
            //int sayi;
            //Console.Write("Sayı giriniz: ");
            //sayi = Convert.ToInt16(Console.ReadLine());
            //Console.Write(sayi);

            // İki sayının toplamı:
            /*
            int s1, s2, toplam;
            Console.Write("Sayı 1: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayı 2: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            toplam = s1 + s2;
            Console.Write("Toplam: "+ toplam); 

            Console.Read();
            */


            // Double Dönüşümü
            // Dönüşüm komutu = Convert.ToDouble();


            // Char Dönüşüm
            // tek karekter alır 
            // Dönüşüm komutu = Convert.ToChar();


            // Byte Dönüşüm
            // 0 - 255 arasında değer alır
            // Dönüşüm komutu = Convert.ToByte();


            // Sbyte Dönüşüm
            // -128 ile 127 arasında değer alabilir.
            // Dönüşüm komutu = Convert.ToSbyte();


            // Float Dönüşüm
            // Dönüşüm komutu = float.Parse();
            // kod kısmından ondalıklı bir değer gönderirken sonuna "f" koymalıyız

            //float sayi;
            //sayi = 45.365f;
            //Console.Write(sayi);

            //Console.Read();
            /*
            float s1,s2,toplam;
            Console.Write("Sayı 1: ");
            s1 = float.Parse(Console.ReadLine());
            Console.Write("Sayı 2: ");
            s2 = float.Parse(Console.ReadLine());

            toplam = s1 + s2;
            Console.WriteLine("Toplam: " +toplam);

            Console.Read();
            */


        }
    }
}

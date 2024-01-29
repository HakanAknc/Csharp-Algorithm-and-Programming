using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geriye_Deger_Donduren_Metot
{
    internal class Program
    {
        public static int toplama()
        {
            int sayi1, sayi2, sonuc;
            sayi1 = 25;
            sayi2 = 10;
            sonuc = sayi1 + sayi2;
            return sonuc;
            
        }
        public static void YildizBosluk()
        {
            Console.WriteLine();
            Console.Write("***************");
            Console.WriteLine();

        }
        public static int toplam(int s1,  int s2)
        {
            int sonuc;
            sonuc = s1 + s2;
            return sonuc;
        }
        static void Main(string[] args)
        {
            // Geriye değer döndüren metot
            Console.Write("Toplam: " + toplama());

            YildizBosluk();
            
            //Geriye Değer Döndüren Parametreli Metot
            Console.WriteLine("Toplam: " + toplam(25, 20));

            YildizBosluk();

            // Kullanıcıdan değer alıp toplayan kod?
            int sayi1, sayi2;
            Console.Write("1.Sayıyı giriniz: ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.Sayıyı giriniz: ");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Sonuç: " + toplam(sayi1, sayi2));

            Console.Read();
        }
    }
}

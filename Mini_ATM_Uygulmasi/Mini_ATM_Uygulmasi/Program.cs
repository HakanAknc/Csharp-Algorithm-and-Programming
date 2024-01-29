using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_ATM_Uygulmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya soracağız nasıl bir işlem yapmak istediğini
            // 1- Bakiye Görüntüleme
            // 2- Para Çekme
            // 3- Para Yatırma
            // 4- "q" ye basarsa kullanıcı çıkış yapsın

            int bakiye = 1000;

            Console.WriteLine("Mini ATM Uygulamasına Hoşgeldiniz :) | (:");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz: " + bakiye);
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğniz tutarı giriniz: ");
                int cekilecek_tutar = Convert.ToInt16(Console.ReadLine());

                if (cekilecek_tutar <= bakiye)
                {
                    Console.WriteLine("Kalan Tutar: " + (bakiye - cekilecek_tutar));
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz.");
                }
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istediğinzi tutarı giriniz: ");
                int yatirilacak_tutar = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Yeni bakiyeniz: " + (bakiye + yatirilacak_tutar));
            }
            else if(secim == "q") 
            {
                Console.WriteLine("Mini ATM'den çıkış yapılıyor...");
                Console.WriteLine("Çıkış yapıldı İyi günler :)");
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değr giriniz.");
            }

            Console.Read();
        }
    }
}

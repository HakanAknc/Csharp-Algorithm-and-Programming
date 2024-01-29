using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanici_adi_Sifre_Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullanaci, sifre;
            Console.Write("Kullanıcı Adınız: ");
            kullanaci = Console.ReadLine();
            Console.Write("Şifreniz: ");
            sifre = Console.ReadLine();

            if (kullanaci == "admin" & sifre == "123456") 
            {
                Console.WriteLine("Hoşgeldiniz :)");
            }
            else
            {
                Console.WriteLine("Hatalı giriş :(");
            }

            Console.Read();
        }
    }
}

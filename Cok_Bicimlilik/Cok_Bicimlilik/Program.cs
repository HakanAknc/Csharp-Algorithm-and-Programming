using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cok_Bicimlilik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            papagan p = new papagan();
            p.tur = "Papağan";
            p.hiz = 50;
            p.isim = "Sultan";
            p.renk = "Sarı - Kırmızı";
            p.agirlik = 1650;
            p.sescikar();

            Console.WriteLine("Tür: " + p.tur);
            Console.WriteLine("İsim: " + p.isim);
            Console.WriteLine("Hız: " + p.hiz);
            Console.WriteLine("Ağırlık: " + p.agirlik);
            Console.WriteLine("Renk: " + p.renk);
            Console.WriteLine("Ses: " + p.sescikar());

            Console.WriteLine();
            Console.WriteLine("**********");
            Console.WriteLine();
            Console.WriteLine();

            karga k = new karga();
            k.agirlik = 1350;
            k.hiz = 80;
            k.isim = "Alacakarga";
            k.renk = "Siyah";
            k.tur = "Karga";
            k.sescikar();

            Console.WriteLine("Tür: " + k.tur);
            Console.WriteLine("İsim: " + k.isim);
            Console.WriteLine("Hız: " + k.hiz);
            Console.WriteLine("Ağırlık: " +k.agirlik);
            Console.WriteLine("Renk: " + k.renk);
            Console.WriteLine("Ses: " + k.sescikar());

            Console.Read();
        }
    }
}

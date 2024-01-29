using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
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
            p.ses = "Cik Cik";
            p.agirlik = 1650;

            Console.WriteLine("Tür: " + p.tur);
            Console.WriteLine("İsim: " + p.isim);
            Console.WriteLine("Hız: " + p.hiz);
            Console.WriteLine("Ağırlık: " + p.agirlik);
            Console.WriteLine("Ses: " + p.ses);
            Console.WriteLine("Renk: " + p.renk);

            Console.Read();
        }
    }
}

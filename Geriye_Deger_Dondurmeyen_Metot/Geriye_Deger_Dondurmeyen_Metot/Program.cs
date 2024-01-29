using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geriye_Deger_Dondurmeyen_Metot
{
    internal class Program
    {
        // Geriye değer döndürmüyorsa => void kullan
        // Geriye değer döndürüyorsa => void kullanma
        public static void yazdir()
        {
            Console.Write("Bu bir metottur.");
            Console.WriteLine();
            Console.Write("Burası metodun bir başka satırdır.");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            yazdir();
            Console.WriteLine("*****************");
            Console.WriteLine();
            yazdir();
            Console.Read();

        }
    }
}

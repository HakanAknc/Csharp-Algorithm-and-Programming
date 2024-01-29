using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematiksel_Fonskiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Math
            double sayi;
            Console.Write("Sayı giriniz: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mutlak değer: " + Math.Abs(sayi));
            Console.WriteLine("Üst taban: " + Math.Ceiling(sayi));
            Console.WriteLine("Alt taban: " + Math.Floor(sayi));
            Console.WriteLine("Karekök: " + Math.Sqrt(sayi));
            Console.WriteLine("Üst alma: " + Math.Pow(sayi,2));

            Console.Read();
        }
    }
}

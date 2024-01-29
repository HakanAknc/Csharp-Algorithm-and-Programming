using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir;
            Console.Write("Şehir adı: ");
            sehir = Console.ReadLine();
            if (sehir == "Adana")
            {
                Console.WriteLine("Doğru şehir :)");
            }
            else
            {
                Console.WriteLine("Yanlış şehir :(");
            }
            Console.Read();
        }
    }
}

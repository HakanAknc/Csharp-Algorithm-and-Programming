using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar__Asiri_Yukleme
{
    internal class Program
    {
        public static int ortalama(int s1, int s2)
        {
            int sonuc = (s1 + s2) / 2;
            return sonuc;
        }
        public static int ortalama(int s1, int s2, int s3)
        {
            int sonuc = (s1 + s2 + s3) / 3;
            return sonuc;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Ortalama: " + ortalama(50, 85));
            Console.WriteLine("Ortalama: " + ortalama(10, 80, 75));
            Console.Read();
        }
    }
}

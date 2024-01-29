using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                k++
                k+=1
                k = k +1
                Hepsi aynı anlamı ifade eder.
             */

            // -> Ekrana 1'den 10'a kadar olan sayıları yazdıran program
            //int i;
            //for (i  = 0; i < 11;  i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();


            // -> Ekran ikişer ikişer 20'ye kadar olan sayıları yazdıran program
            //int j;
            //for (j = 0; j < 21; j += 2) 
            //{
            //    Console.WriteLine(j);
            //}
            //Console.Read();


            // -> Ekrana 100 defa Merhana İstanbul yazdrın program
            int k;
            for (k = 0; k <= 100; k++)
            {
                Console.WriteLine(k + " Merhaba İstanbul :)");
            }
            Console.Read();
        }
    }
}

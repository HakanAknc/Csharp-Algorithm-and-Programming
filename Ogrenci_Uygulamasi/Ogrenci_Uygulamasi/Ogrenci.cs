using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Uygulamasi
{
    public class Ogrenci
    {
        private int ogrNo;

        private string isim;

        private string soyisim;

        private int vize1;

        private int vize2;

        private int final;

        private string okulIsmi;


        public Ogrenci(int _ogrNo, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulIsmi)
        {
            ogrNo = _ogrNo;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;
        }




        public void OgrenciBilgiGoster()
        {
            Console.WriteLine("Öğrenci Numrası: " + ogrNo);
            Console.WriteLine("Öğrenci İsmi: " + isim);
            Console.WriteLine("Öğrenci Soyismi: " + soyisim);
            Console.WriteLine("Öğrenci vize1: " + vize1);
            Console.WriteLine("Öğrenci vize2: " + vize2);
            Console.WriteLine("Öğrenci final: " + final);
            Console.WriteLine("Öğrenci Okul İsmi: " + okulIsmi);
        }

        public double OgrenciNotuHesapla()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin Okul İsmi: " + okulIsmi);
        }
    }
}

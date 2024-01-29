using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    class Musteri
    {
        public int id;
        private string ad;
        private string soyad;
        public string sehir;

        public string Ad { get => ad; set => ad = value.ToLower(); }   // property  // get => değeri geriye döndürür   // set => kısıtlama yapar
        public string Soyad 
        { 
            get => soyad; 
            set => soyad = value.ToUpper(); 
        }
    }
}

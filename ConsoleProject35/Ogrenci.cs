using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject35
{
    class Ogrenci
    {
        public int Yas { get; set; } //prop yazıp tab tab 
        public int Isim { get; set; }
        public int SoyIsim { get; set; }
        public int Yaslandir (int eskiYas)
        {
            //int yeniYas = eskiYas + 1;
            //Yas = yeniYas;
            //return yeniYas;

            return Yas = eskiYas + 1; // yukarıdaki kodu soldaki gibi de yazabilirdik
        }
    }
}

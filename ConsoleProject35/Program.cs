using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject35
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogr = new Ogrenci();
            ogr.Yas = 20;
            //Program prm = new Program();
            //prm.Metot2();
            Metot2(ogr);
            Console.WriteLine("Yas değeri : " + ogr.Yas);// Yas değeri konsolda ne olur ??? 
            Console.ReadLine();

        }
        private static void Metot2( Ogrenci o )//static yazarsan instanse (prm ) yaratmadan direk çağırılabilir.
        {
            o.Yas = 30;


        }
    }   
}

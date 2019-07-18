using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject42
{
    class Program
    {   //ENUM örneği //
        public enum DersKodlari
        {
            MSWORD ,// Bu şekilde atama yapılmadığında default olarak 0,1,2..olarak ders kodu ataması yapar.
            MSEXCEL ,
            MSPOWERPOINT,
            MSOUTLOOK = 333//Ders kodu 333 yerine MSWORD yazılmak istendiğinde enum kullanılabilir.
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Lütfen W, E, P, O harflerinden birini giriniz.");
                char c = Convert.ToChar(Console.ReadLine().ToUpper());
                int dersSaati = 0;
                int s = HarfeGoreDersBelirle(c);
                Console.WriteLine("without int "+ DersKodlari.MSWORD);
                Console.WriteLine("with int "+ (int)DersKodlari.MSWORD);
                if (s == (int)DersKodlari.MSWORD)
                    dersSaati = 10;
                else if (s == (int)DersKodlari.MSEXCEL)
                    dersSaati = 30;
                else if (s == (int)DersKodlari.MSPOWERPOINT)//Bu şekilde yazıldığında ENUM'daki ders kodlarında değişiklikler yapıldığında kodda değişiklik yapmamıza gerek kalmaz.
                    dersSaati = 5;
                else if (s == 333)// Bu şekilde yazıldığında enum içinde outlookun kodu değiştiğinde burayı da güncellememiz gerekecek.
                    
                    dersSaati = 15;
                else
                {
                    dersSaati = 0;
                    continue;
                }
                Console.WriteLine(s + " dersinin haftalık ders saati = " + dersSaati);
                Console.ReadLine();
            }
        }
        public static int HarfeGoreDersBelirle(char dersHarfi)//access modifiers= public
        {
            string dersAdi = "";
            int dersKodu = 0;
            if (dersHarfi == 'W')
            {
                dersAdi = "MSWORD";
                dersKodu = (int)DersKodlari.MSWORD;
            }
            else if (dersHarfi == 'E')
            {
                dersAdi = "MSEXCEL";
                dersKodu = (int)DersKodlari.MSEXCEL;
            }
            else if (dersHarfi == 'P')
            {
                dersAdi = "MSPOWERPOINT";
                dersKodu = (int)DersKodlari.MSPOWERPOINT;
            }
            else if (dersHarfi == 'O')
            {
                dersAdi = "MSOUTLOOK";
                dersKodu = (int)DersKodlari.MSOUTLOOK;
            }
            else
                Console.WriteLine("Geçerli bir harf girmediniz!");
            if (dersAdi != "")
                Console.WriteLine(dersAdi);
            return dersKodu;
        }
    }
}
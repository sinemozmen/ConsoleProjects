using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayıyı gir : ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı gir : ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            long toplamSonucu = IkiSayininFaktoriyelToplami(s1, s2);
            Console.WriteLine(s1 + "!+" + s2 + "! =" + toplamSonucu);
            Console.ReadLine();
        }
        public static long Faktoriyel(int n)
        {
            long faktoriyel = 1;
            if (n == 0)
                return 1;

            for (int i = 1; i <= n; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            return faktoriyel;
        }
        public static long IkiSayininFaktoriyelToplami(int sayi1, int sayi2)
        {
            long sayi1FaktoriyelSonucu = Faktoriyel(sayi1);
            sayi1FaktoriyelSonucu = Faktoriyel(sayi1);

            long sayi2FaktoriyelSonucu = Faktoriyel(sayi2);

            //long sonuc = sayi1FaktoriyelSonucu + sayi2FaktoriyelSonucu;
            //return sonuc;

            return sayi1FaktoriyelSonucu + sayi2FaktoriyelSonucu;
        }
    }
}


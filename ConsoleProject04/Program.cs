using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject04
{
    class Program
    {
        static void Main(string[] args)
        {
           int sayi = 350;
           

            Console.WriteLine($"int gösteriliyor {sayi}");
            Console.WriteLine("");


            //byte sayiByte = sayi;// Soldaki codeline implicit conversion yancak uygun değil.
            //Çünkü büyük veri tipi, daha küçük bir veri tipine dönüştürülmek istenmiştir.Bu durum veri kaybına
            //yol açacağı için hata vermiştir.Ama bilinçli bir çevirim söz konusu ise , bu durum explicit conversion ile çözülebilir.
            //
            byte sayiByte = (byte)sayi;// explicit conversion 

            Console.WriteLine($"int to byte gösteriliyor {sayiByte}");
            Console.WriteLine("");

            long sayiLong = sayi;// implicit conversion

            Console.WriteLine($"int to long gösteriliyor {sayiLong}");
            Console.WriteLine("");
            Console.ReadLine();

            double x = 1234.7;
            int a1;
            int a2;
            // cast double to int ve gösterimi
            a1 = (int)x;// truncate double 
            Console.WriteLine($"double to int gösteriliyor : {a1}");
            a2 = Convert.ToInt32(x);//convert to int 
            Console.WriteLine($"double to int conversion : {a2}");
            Console.Beep(300,3000);
            System.Threading.Thread.Sleep(3000);// 3 saniye bekletir.
            //Console.ReadLine();



        }
    }
}

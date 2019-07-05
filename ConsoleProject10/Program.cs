using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string girilen;

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Lütfen bir sayı giriniz ");
                girilen = Console.ReadLine();
                if (girilen == "q" || girilen == "Q")
                    return;

                try
                {
                    a = Int32.Parse(girilen);
                    Console.Write("3000 / " + a + " = ");
                    Console.WriteLine(3000 / a);
                    Console.WriteLine("İşlem başarılı bir şekilde sonuçlandı");
                    //Console.ReadLine();
                }
                catch (DivideByZeroException nesne)
                {
                    Console.WriteLine("Sayı sıfıra bölünemez !" + nesne.Message + "Kaynak:" + nesne.Source);
                }
                catch (Exception nesne)// bu blok en sonda olmalı
                {
                    Console.WriteLine("Hata var!" + nesne.Message);

                }
                finally
                {
                    Console.WriteLine("Programdan çıkmak için q/Q harfine basınız.");
                }
            } while (true);// Koşulsuz şartsız döner.

        }
    }


                
}





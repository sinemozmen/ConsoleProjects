using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHILE ILE COZUM:

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Lütfen bir sayı giriniz veya programdan çıkmak için \"q\" veya \"Q\" harflerine basınız.");
            //        string girilenDeger = Console.ReadLine();
            //        if (girilenDeger == "q" || girilenDeger == "Q")
            //        {
            //            return;// return'da metot dışına çıkar.Burada main methodunun dışına çıkar.Break'te looptan çıkar.
            //        }

            //        int a = Int32.Parse(girilenDeger);
            //        Console.Write("3000 / " + a + " = ");
            //        Console.WriteLine(3000 / a);
            //        Console.WriteLine("İşlem başarılı bir şekilde sonuçlandı");
            //        //Console.ReadLine();
            //    }
            //    catch (DivideByZeroException nesne)
            //    {
            //        Console.WriteLine("Sayı sıfıra bölünemez !" + nesne.Message + "Kaynak:" + nesne.Source);
            //    }
            //    catch (Exception nesne)// bu blok en sonda olmalı
            //    {
            //        Console.WriteLine("Hata var!" + nesne.Message);
            //    }
            //}

            //DO - WHILE ILE COZUMU 

            //do
            //{
            //    try
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Lütfen bir sayı giriniz veya programdan çıkmak için \"q\" veya \"Q\" harflerine basınız.");
            //        string girilenDeger = Console.ReadLine();
            //        if (girilenDeger == "q" || girilenDeger == "Q")
            //        {
            //            return;
            //        }

            //        int a = Int32.Parse(girilenDeger);
            //        Console.Write("3000 / " + a + " = ");
            //        Console.WriteLine(3000 / a);
            //        Console.WriteLine("İşlem başarılı bir şekilde sonuçlandı");
            //        //Console.ReadLine();
            //    }
            //    catch (DivideByZeroException nesne)
            //    {
            //        Console.WriteLine("Sayı sıfıra bölünemez !" + nesne.Message + "Kaynak:" + nesne.Source);
            //    }
            //    catch (Exception nesne)// bu blok en sonda olmalı
            //    {
            //        Console.WriteLine("Hata var!" + nesne.Message);
            //    }
            //}
            //while (true);

            string girilenDeger = "" ;// string girilenDeger = null 

            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Lütfen bir sayı giriniz veya programdan çıkmak için \"q\" veya \"Q\" harflerine basınız.");
                    girilenDeger = Console.ReadLine();
                    //if (girilenDeger == "q" || girilenDeger == "Q")
                    //{
                    //    return;
                    //}

                    int a = Int32.Parse(girilenDeger);
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
                    if (girilenDeger != "Q" && girilenDeger != "q")
                    {
                        Console.WriteLine("Hata var!" + nesne.Message);
                    }
                }
            }
            while (girilenDeger != "Q" && girilenDeger !="q");
        }
    }
}



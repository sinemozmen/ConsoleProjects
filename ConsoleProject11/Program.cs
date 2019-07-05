using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject11
{
    class Program
    {
        static void Main(string[] args)
        {// Öğrencinin aldığı 2 notu ekrana girerek ortalamasını ve 5 tabanında notunu yazdırınız.
         //Not skalası : 0-24 arası 0, 25-44 arası 2, 45-54 arası 2 , 55-69 arası 3, 70-85 arası 4, 86-100 arası 5 
            while (true)
            {


                uint not1;
                uint not2;
                double ortalama;
                string girilen;
                string s;

                try
                {
                    Console.WriteLine("1. yazılı notunu giriniz veya Q yazarak programdan çıkınız ");
                    girilen = Console.ReadLine();
                    s = girilen.ToUpper();// girilen stringi büyük harf yapar
                    if (s == "Q")
                        return;

                    not1 = UInt32.Parse(girilen);

                    while (not1 > 100)
                    {
                        Console.WriteLine("0-100 arasında bir değer girmelisiniz");
                        not1 = UInt32.Parse(Console.ReadLine());

                    }

                    Console.WriteLine("2.yazılı notunu giriniz. ");
                    not2 = UInt32.Parse(Console.ReadLine());

                    while (not2 > 100)
                    {
                        Console.WriteLine("0-100 arasında bir değer girmelisiniz");
                        not2 = UInt32.Parse(Console.ReadLine());
                        Console.ReadLine();
                    }

                    ortalama = (double)(not1 + not2) / 2;
                    Console.WriteLine($"Ortalamanız = {ortalama}");

                    if (ortalama == 0)
                    {
                        Console.WriteLine("5'lik sistemde notunuz = 0 ");
                        Console.ReadLine();
                    }
                    else if (ortalama > 0 && ortalama < 25)
                    {

                        Console.WriteLine("5'lik sistemde notunuz = 0 ");
                        Console.ReadLine();
                    }
                    else if (ortalama > 24 && ortalama < 45)
                    {
                        Console.WriteLine("5'lik sistemde notunuz = 1 ");
                        Console.ReadLine();
                    }
                    else if (ortalama > 45 && ortalama < 55)
                    {
                        Console.WriteLine("5'lik sistemde notunuz = 2 ");
                        Console.ReadLine();
                    }
                    else if (ortalama > 54 && ortalama < 70)
                    {
                        Console.WriteLine("5'lik sistemde notunuz = 3 ");
                        Console.ReadLine();
                    }
                    else if (ortalama > 69 && ortalama < 86)
                    {
                        Console.WriteLine("5'lik sistemde notunuz = 4 ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("5'lik sistemde notunuz = 5 ");
                        Console.ReadLine();
                    }

                }
                catch (FormatException formatExp)

                {
                    Console.WriteLine("Hatalı bir tuşlama yaptınız.", formatExp.Message);
                    Console.ReadLine();

                }
                catch (Exception exp)
                {

                    Console.WriteLine("Hatalı biri işlem yaptınız.", exp.Message);
                    Console.ReadLine();
                }

            }
        }
    }
}

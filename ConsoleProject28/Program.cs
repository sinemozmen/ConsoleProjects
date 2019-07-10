using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject28
{
    class Program
    {
        static void Main(string[] args)
        {

            // Girilen sayının faktöriyelini hesaplayan program

            
            while (true)
            {
                int girilen;
                int carpim = 1;
                int i = 0;

                try
                {

                    Console.WriteLine("Kaç adet sayının faktöriyelini hesaplamak istersiniz");
                    girilen = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Hatalı giriş");
                    continue;
                }
                    Console.WriteLine(0 + " sayısının faktöriyeli = " + 1);

                for (i = 1; i <= girilen; i++)
                {
                    carpim = carpim * i;
                    Console.WriteLine(i + " sayısının faktöriyeli = "  + carpim);
                }
                Console.ReadLine();
            }
        }
    }
}

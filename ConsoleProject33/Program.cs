using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject33
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gunler = new string[7];
            gunler[0] = "Pazastesi";
            gunler[1] = "Salı";
            gunler[2] = "Çarşamba";
            gunler[3] = "Perşembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";

            Console.WriteLine("Clear Metotu Öncesi - FOR'lu ");
            for (int i = 0; i <= 6; i++) 
            {
                Console.WriteLine("Array'in " + (i + 1) + ".elemanı=" + gunler[i]);
            }

            Console.ReadLine();
            Console.WriteLine("Clear Metotu Öncesi - FOREACH'li ");

            int j = 1;
            foreach (string gun in gunler)
            {
                Console.WriteLine("Array'in {1}. elemanı= {0}", gun,j++);
            }
            Console.ReadLine(); 

            Array.Clear(gunler, 0, 3);// Clear metotunda veriyi siler , arrayin boyutu değişmez.

            Console.ReadLine();
            Console.WriteLine("Clear Metotu Sonrası ");

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine("Array'in " + (i + 1) + ".elemanı=" + gunler[i]);
            }
            Console.ReadLine();
        }   
    }
}

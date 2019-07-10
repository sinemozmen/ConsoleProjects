using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject27
{
    class Program
    {
        static void Main(string[] args)
        {// Girilen sayının faktöriyelini hesaplayan progra

            int girilen;
            int carpim=1;
            string okunan="";
            int i = 0;
            while (true) 
            {
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
                if (girilen == 0) 
                {

                    Console.WriteLine(girilen + " sayısının faktöriyeli " + 1);
                    continue;
                
                }

                for (i=1 ; i <= girilen; i++)
                {

                   
                    carpim = carpim * i;

                    if(girilen==i)

                    {
                        okunan = okunan + Convert.ToString(i);

                    }
                    else
                    {
                        okunan = okunan + Convert.ToString(i) + "*";

                    }
                    


                }
                Console.WriteLine(girilen + " sayısının faktöriyeli = " + okunan + "=" + carpim);
                Console.ReadLine();
                    
            }            
        }
    }
}

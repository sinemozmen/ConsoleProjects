using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject25
{
    class Program
    {
        static void Main(string[] args)
        {   
            int toplam = 0 ;
            int sayac = 1 ;
            int sayi=0;
            
            

            Console.WriteLine("Kaç adet sayının toplanmasını istersiniz ? ");
            int girilen = Convert.ToInt32(Console.ReadLine());
           // int [] dizi = new int [girilen];
                while(sayac<=girilen)
                     //for(int i =0; i< girilen;i++)
                {   
                    Console.WriteLine(sayac+" . sayıyı giriniz ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(sayi+"+");
                    Console.ReadLine();
                    sayac++;
                    toplam=toplam+sayi;
                     Console.Write(sayi+"+"+toplam);
                    
                   
                    //dizi[i]=sayi;
                    //Console.WriteLine(dizi[i]);
                    
                }
            
                Console.ReadLine();




        }
    }
}

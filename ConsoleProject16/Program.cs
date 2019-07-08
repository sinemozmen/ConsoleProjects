using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject16
{
    class Program
    {
        static void Main(string[] args)
        {//Kullanıcının girdiği satır ve sütun sayısı kadar* koyan program yazınız.

            uint satirSayisi;
            uint sutunSayisi;

            try
            {
                Console.WriteLine("Satır sayısını giriniz.");
                satirSayisi = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Sütun sayısını giriniz");
                sutunSayisi = Convert.ToUInt32(Console.ReadLine());
                for (int i = 1; i <= satirSayisi; i++) 
                {
                    for (int b = 1; b < sutunSayisi; b++) 
                    {
                        Console.Write("*");
                        
                    }
                    Console.WriteLine("*");   
                }
                   
            }
            catch(FormatException exp)
            {
                Console.WriteLine("Hatali bir tuşlama yaptınız.", exp.Message);
                Console.ReadLine();

            }
            catch 
            {
                Console.WriteLine("Hatali bir tuşlama yaptınız.");
                Console.ReadLine();

            }
            Console.ReadLine();



        }
          
    }
}

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

            //Girilen sayıya göre
            // 0 sayısının faktöriyeli = 1 
            //1 sayısının faktöriyeli = 1*1=1
            //2 sayısının faktöriyeli = 1*2 =2
            //3 sayısının faktöriyeli= 1*2*3=6....yazdıran programı yazınız.


            while (true)
            {
                int girilen;
                int carpim = 1;
                int i = 0;
                string okunan = "";

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
                    
                    if (i==girilen)
                    {
                        okunan = okunan + Convert.ToString(i);
                        Console.WriteLine(i + " sayısının faktöriyeli = " +okunan+"="+ carpim);



                    }
                    //else if(i==1)
                    //{

                        
                    //    Console.WriteLine(i+ "sayının faktöriyeli=" + okunan+i+"="+carpim);
                    //}
                    else
                    { 
                        if(okunan.Length>0)
                        {
                            okunan = okunan + Convert.ToString(i) + "*";
                            okunan = okunan.Remove(okunan.Length - 1);
                            Console. WriteLine(i + "sayının faktöriyeli=" + okunan + "=" + carpim);
                            continue;

                           



                        }



                    }
                    Console.ReadLine();
                }
                   
            }
        }
    }


}



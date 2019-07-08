using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject19
{
    class Program
    {
        static void Main(string[] args)
        {//1-Sayma işleminin 1'den başlayarak 100'e kadar birer birer
         //devam ettirilmesi , 5 ve 5'in katlarına gelindiğinde ekrana sayı yerine 
         //BOM yazdırılması

            //2- Kendisine ve katlarına gelindiğinde BOM denilecek olan sayının
            //Console ekranından kullanıcı tarafından girilmesinin istenmesi,oyundaki
            //sayma işleminin bu girilen sayıya göre doğru şekilde ekrana yazdırılması 

            //3- BOM denilecek sayının aynı şekilde kullanıcı tarafından girilmesinin ardından oyunun bilgisayar
            //tarafından başlatılması,sırayla kullanıcı ve bilgisayar arasında devam ettirilmesi

            //NOT:Aşama 3'te BOM sırası kullanıcıya geldiğinde erkendan BOM yerine sayı girilirse kullanıcı oyunu
            //kaybeder.
            //Bilgisayar oyunu karar yapılarına dayalı olarak oynanacağından kaybetmesi durumu göz önüne alınmayacaktır.
            //Oyun 100'e kadar devam ettirilecek olup kullanıcının kullanıcının kaybetmemiş olması durumunda beraberlik durumu 
            //geçerli olacaktır ve ekr

            //1.OYUN//
            //for (int i = 1; i<=100;i++)
            //{

            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine("**BOM**");


            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //        System.Threading.Thread.Sleep(500);
            //    }
            //}

            //2.OYUN

            //Console.WriteLine("Hangi sayı katlarında BOM yazılmasını istersiniz");
            //int BOMKatsayisi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 100; i++)
            //{

            //    if (i % BOMKatsayisi == 0)
            //    {
            //        Console.WriteLine("**BOM**");
            //        continue;


            //    }
            //        Console.WriteLine(i);
            //        System.Threading.Thread.Sleep(500)                
            //}

            //3.OYUN
            int hataSayisi = 0;
            Console.WriteLine("Hangi sayı katlarında BOM yazılmasını istersiniz");
            int girilenBOM =Convert.ToInt32( Console.ReadLine());
            //girilenBOM.All(char.IsDigit))// stringin içindeki karakter sayı mı,karakter mi vs. analiz eder
            for (int i = 1; i <= 20; i++)
            { if(i%2==0)//bilgisayardır
                {
                    if (i % girilenBOM == 1)

                    {
                        if (i % girilenBOM == 0)
                        {
                            Console.WriteLine("Bilgisayar: BOM");

                        }
                        else
                        {
                            Console.WriteLine("Bilgisayar:" + i);
                        }






                    }

                }
                else
                {
                    if (i % girilenBOM == 0) //SİZ
                    {
                        string girilenSayi = Console.ReadLine();
                        if (girilenSayi != "BOM" || girilenSayi != "bom")
                        {
                          
                            hataSayisi = hataSayisi + 1;
                        }
                        Console.WriteLine("Siz : BOM");
                    }
                    else
                    {
                        Console.WriteLine("Siz:" + i);
                       

                    }




                }



            }   


         
               

        }
    }
}

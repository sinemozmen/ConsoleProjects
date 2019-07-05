using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject12
{
    class Program
    {
        static void Main(string[] args)
        {// 1-7 arasında sayı girildiğinde haftanın günlerini veren bir switch-case yapısı oluşturunuz.

            int sayi;
            string girilen = "";
            while(true)
            try
            {
                    Console.WriteLine("***");
                    Console.WriteLine("1-7 arasında bir sayı giriniz veya programdan çıkmak için Q tuşuna basınız. ");
                   
                girilen = Console.ReadLine();
                    string a = girilen.ToUpper();

                    if (a == "Q")
                   
                        return;
                                    
                sayi = Convert.ToInt32(girilen);
                    if (sayi > 7)

                        Console.WriteLine("Hatalı bir tuşlama yaptınız.Lütfen 1-7 arasında bir sayı giriniz. ");

                switch (sayi)
                {
                    case 1:
                        Console.WriteLine(" Girdiğiniz gün = Pazartesi");
                        break;
                    case 2:
                        Console.WriteLine(" Girdiğiniz gün = Salı");
                        break;
                    case 3:
                        Console.WriteLine(" Girdiğiniz gün =  Çarşamba");
                        break;
                    case 4:
                        Console.WriteLine(" Girdiğiniz gün = Perşembe");
                        break;
                    case 5:
                        Console.WriteLine(" Girdiğiniz gün = Cuma");
                        break;
                    case 6:
                        Console.WriteLine(" Girdiğiniz gün = Cumartesi");
                        break;
                    case 7:
                        Console.WriteLine(" Girdiğiniz gün = Pazar");
                        break;
                }
            }catch (FormatException exp)
            {
                Console.WriteLine("Hatalı bir tuşlama yaptınız.", exp.Message);
                Console.ReadLine();
            }
            catch
                {
                    Console.WriteLine("Hatalı bir tuşlama yaptınız.");
                    Console.ReadLine();
                }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject13
{
    class Program
    {
        static void Main(string[] args)
        {//Kullanıcıya hangi mevsimde olduğunu gösteren switch-case yapısını yapınız.
            while (true)
            {
                try
                {
                    Console.WriteLine("Bir ay numarası giriniz veya çıkmak için Q harfine basınız .");
                    string girilen = Console.ReadLine();
                    
                   
                    if (girilen == "Q"|| girilen=="q")
                    {
                        return;
                    }
                    int ayNumarası = Convert.ToInt32(girilen);
                    if (ayNumarası < 1 || ayNumarası > 12)
                    {
                        Console.WriteLine("Lütfen 1-12 arasında bir sayı giriniz!");
                    }
                    switch (ayNumarası)
                    {
                        case 12:
                        case 1:
                        case 2:
                            {
                                Console.WriteLine("Kış mevsimi");
                                break;
                            }

                        case 3:
                        case 4:
                        case 5:
                            {
                                Console.WriteLine("İlkbahar mevsimi");
                                break;
                            }
                        case 6:
                        case 7:
                        case 8:
                            {
                                Console.WriteLine("Yaz mevsimi");
                                break;
                            }
                        case 9:
                        case 10:
                        case 11:
                            {
                                Console.WriteLine("Sonbahar mevsimi");
                                break;
                            }
                    }

                }
                catch (FormatException exp)
                {

                    Console.WriteLine("Hatalı bir giriş yaptınız.", exp.Message);
                }
                catch
                {

                    Console.WriteLine("Hatalı bir giriş yaptınız.");
                }

            }
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject17
{
    class Program
    {
        static void Main(string[] args)
        {//Belirlenen kullanıcı adı ve şifre doğru girildiğinde "Giriş Başarılı",
         //Yanlış girilidğinde "Girdiğiniz kullanıcı adı veya şifre hatalı " mesajı veren console uygulamasını yapınız.
         //Kullanıcı adı "admin" ve şifre "123456"
            
            while (true) 
            {
                Console.WriteLine("Kullanıcı adı giriniz.");
                string kullanıcıAdi = Console.ReadLine();

                if (kullanıcıAdi != "admin")
                {
                    Console.WriteLine("Kullanıcı adı hatalı");
                    Console.WriteLine("");
                    continue;

                }
                int sayac = 5;
                while(sayac > 0  )
                {
                    
                    Console.WriteLine("Şifre giriniz");
                    string sifre = Console.ReadLine();

                    if (sifre != "123456")
                    {
                        Console.WriteLine("Sifre hatalı");
                        sayac = sayac - 1;
                        Console.WriteLine("Toplam " + sayac + " deneme hakkınız kaldı.");
                        continue;
                    }
                    else
                    {

                        break;// burada return kullanamayız.

                    }
                    
                }
                if (sayac == 0) 
                {
                    Console.WriteLine("Şifre deneme hakkınız bitmiştir");
                    Console.ReadLine();
                    return;
                }


                Console.WriteLine("Giriş başarılı");
                Console.ReadLine();
                return;// whileden kurtulmak için kullanılır.Burada while dışına çıkmak için break de kullanabiliriz.

                //if (kullanıcıAdi == "admin" && sifre == "123456")
                //{
                //    Console.WriteLine("Giriş başarılı.");
                //    Console.ReadLine();
                //}
                //else
                //{
                //    Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı");
                //    Console.ReadLine();
                //}

            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Birinci scope(blok)
            //int a = 20;
            //Console.WriteLine(a);//a'yı ekrana yazdıracakü
            //Console.ReadLine();// Enter'a basana kadar Writeline 'dan gelen değer ekranda kalır.Ekrana girilen tüm değerleri okur.
            //Console.ReadKey();// Herhangi bir karaktere basınca ekrandan çıkıyor.Sadece ilk karakteri okuyor.

            string isim = "";
            string soyIsim = "";

            Console.WriteLine("Lütfen isminizi giriniz. ");
            isim=Console.ReadLine();
            Console.WriteLine("Lütfen soyadinizi giriniz.");
            soyIsim = Console.ReadLine();

            
            string adSoyad;
            adSoyad = isim + "\" Merhaba \" " + soyIsim; // " karakterinin metin içinde gözükmesi için \* kullanılır
            adSoyad = isim + "\\ Merhaba \\"  + soyIsim;
            adSoyad = isim + "\\" +"Merhaba" +"\\ " + soyIsim; // \ karakterinin metin içinde gözükmesi için \\ kullanılır
            
            Console.WriteLine(adSoyad);

            adSoyad = isim + "  " + soyIsim;

          

            adSoyad = isim + " ( "+ soyIsim+" )" ; // "merhaba" yazacak :D 
            
            Console.WriteLine(adSoyad);

        

            Console.WriteLine(isim + "--" + soyIsim);

            Console.ReadLine();

            //ctrl+backspace silmek için kullanılır :)

           //intelisense
                // classin içindeki ingiliz anahtarı : properties,
                // mor küp: classin içindeki metot
                //yıldırım: classin içinde tanımlı Event'leri gösterir.
                //
        }
    }

    //class Program2
    //{
    //    /* ctrl+k+c*/ /*seçilen kodu comment yapar*/

    //}
    
    class Program2
    {
        /* ctrl+k+u*/ /*uncomment*//*seçilmiş kodun commentini kaldırır*/

    }
    class Program3
    {
        /* ctrl+k+d*/ /*design*//*kod bozulduğunda indentation yapar*/

    }





}

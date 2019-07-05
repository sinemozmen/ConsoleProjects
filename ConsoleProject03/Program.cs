using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject03
{
    class Program
    {
        private static void Main(string[] args)
        {
            //int sayi1;
            //int sayi2;
            //float sonuc;
            //string a;
            //string b;

            //Console.WriteLine("Lütfen 1. Sayıyı giriniz");
            //a = Console.ReadLine();
            //sayi1 = Int32.Parse(a);


            //Console.WriteLine("Lütfen 2.Sayıyı giriniz.");
            //b = Console.ReadLine();
            //sayi2 = Int32.Parse(b);

            //sonuc = sayi1 / sayi2;

            //Console.WriteLine($"İşlemin sonucu {sonuc}");// string interpolation
            //Console.ReadLine();



            Console.WriteLine("Lütfen birinci sayıyı giriniz.(Bölünen)");
            string sayi1 = Console.ReadLine();
            int sayiBolunen;
            try// bir kod parçasının exception(hata) alma ihtimali varsa try blogu içine yazılır.
            {
                sayiBolunen = Convert.ToInt32(sayi1);

                //int sayiBolunen = Convert.ToInt32(Console.ReadLine());
            }

            catch// catch blogunda try blogunda oluşacak hata ile ilgili açıklama yapılabilir.

            {
                Console.WriteLine("Girmiş olduğunuz ilk değer düzgün değil");
                Console.ReadLine();
                return;
            }
            finally
            {
                Console.WriteLine("Sizi tekrar aramızda görmek isteriz Ali ");
                Console.ReadLine();

            }


            Console.WriteLine("Lütfen ikinci sayıyı giriniz.(Bölen)");
            string sayi2 = Console.ReadLine();
            int sayiBolen;
            try
            {
                sayiBolen = Convert.ToInt32(sayi2);
                //int sayiBolen = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Girdiğiniz 2.sayı düzgün değil");
                Console.ReadLine();
                return;
            }

            finally
            {
                Console.WriteLine("Sizi tekrar aramızda görmek isteriz Yeşim");
                Console.ReadLine();
                
            }

                       

            //int/int sonucu fractional partı attığı için,
            //yani küsürati kestiği için sonuç int olarak hesaplanıyor.
            //Eğer sonucun küsüratlı kısmını görmek istiyorsak 
            //Aşağıdaki satırdaki gibi explicit conversion yapılabilir.Sayılardan birini açık şekilde double'a cast ettik.
            //double sonuc = (double)sayiBolunen / sayiBolen; //** 1. sayıyı double çevir sonra böl** explicit conversiton 


            

            double sonuc;

            try
            { sonuc = (double)sayiBolunen / sayiBolen;
                //decimal sonuc =Decimal.Divide(sayiBolunen,  sayiBolen);
            }
            catch
            {
                Console.WriteLine("Bölme işlemi sırasında hata oluştu.");
                Console.ReadLine();
                return;
            }
            finally
            {
                Console.WriteLine("Sizi tekrar aramızda görmek isteriz Gülsüm");
                Console.ReadLine();
            }

            Console.WriteLine($"2 sayının bölümünün sonucu: {sonuc}");
            Console.ReadLine();

           
        }
    }
}

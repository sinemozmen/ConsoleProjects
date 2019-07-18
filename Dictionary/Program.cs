using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            // Dictionary(class) - Bir çeşit generic collectiondır.
            //Eklenip çıkartılan elemanlara göre boyutu dinamik olarak DEĞİŞİR.
            //Dictionary<TKey,TValue> 2 parametrelidir.
            //Dizideki indexleri key, değerleri  value olarak düşünebiliriz.
            //YAZIMI:
            //Dictionary<Key_Tipi, Value_Tipi> Referans_Adi = new Dictionary<Key_Tipi, Value_Tipi>();

            //ÖRNEK:Öğrencinin numarası girildiğinde öğrencinin ad-soyad bilgilerini ekrana yazdıran uygulama.

            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();

            Ogrenci.Add(10, "Ayşe");
            Ogrenci.Add(20, "Ali");
            Ogrenci.Add(30, "Veli");
            Ogrenci.Add(40, "İpek");

            Console.Write("Öğrenci No Giriniz:");
            int No = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(Ogrenci[No]);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");//KeyNotFoundException
            }

            //Dictionarylerde Önemli Metotlar: 

            //1-ContainsKey

            //bool varmi = Ogrenci.ContainsKey(20);
            //Console.WriteLine(varmi);
            //Console.ReadLine();

            //2-ContainsValue

            //bool varmi = Ogrenci.ContainsValue("Ayşe");
            //Console.WriteLine(varmi);
            //Console.ReadLine();

            //3-Clear

            //Ogrenci.Clear();

            //4-Count

            //int ElemanSayisi = Ogrenci.Count;
            //Console.WriteLine(ElemanSayisi);
            //Console.ReadLine();

            //5-Remove

            //bool SilindiMi = Ogrenci.Remove(300);
            //Console.WriteLine(SilindiMi);
            //Console.ReadLine();

            //6-Keys

            //Dictionary<int, string> Ogrenci = new Dictionary<int, string>();

            //Ogrenci.Add(10, "Ayşe");
            //Ogrenci.Add(20, "Ali");
            //Ogrenci.Add(30, "Veli");
            //Ogrenci.Add(40, "İpek");

            //Dictionary<int, string>.KeyCollection AnahtarListesi = Ogrenci.Keys;

            //foreach (int Anahtar in AnahtarListesi)
            //    Console.WriteLine(Anahtar);
            //    Console.ReadLine();

            //7-Values

            //Dictionary<int, string> Ogrenci = new Dictionary<int, string>();

            //Ogrenci.Add(10, "Ayşe");
            //Ogrenci.Add(20, "Ali");
            //Ogrenci.Add(30, "Veli");
            //Ogrenci.Add(40, "İpek");

            //Dictionary<int, string>.ValueCollection DegerListesi = Ogrenci.Values;

            //foreach (string Deger in DegerListesi)
            //    Console.WriteLine(Deger);
            //    Console.ReadLine();

            //8-Key Value Pair
            //Dictionary<int, string> Ogrenci = new Dictionary<int, string>();

            //Ogrenci.Add(10, "Ayşe");
            //Ogrenci.Add(20, "Ali");
            //Ogrenci.Add(30, "Veli");
            //Ogrenci.Add(40, "İpek");

            //foreach (KeyValuePair<int, string> veri in Ogrenci)
            //    Console.WriteLine("Numara:{0} - İsim:{1}", veri.Key, veri.Value);
            //    Console.ReadLine();
            
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQueueProject
{
    class Program
    {
        public static void Main()
        {

            // Queue sınıfından bir nesne oluşturalım:

            Queue sira = new Queue();


            // Nesnemize Enqueue metodu ile değerler girelim:

            sira.Enqueue(1994);
            sira.Enqueue("galatasaray");
            sira.Enqueue('a');
            sira.Enqueue(12134 + " Admin");
            sira.Enqueue(null);
            sira.Enqueue(1.1 + 1.2);

            // sira isimli nesnemizin eleman sayısı:
            Console.WriteLine("Sıra nesmemizin eleman sayısı: " + sira.Count);

            // sira isimli nesnemizin elemanları:
            Console.Write("Nesnemizin elemanları: ");
            foreach (object sir in sira)
            {
                Console.Write(sir + " ");
            }
            Console.WriteLine();
            //Contains metodunun kullanımı:

            int sayi1 = 1994;
            string yazi1 = "galatasaray";
            string yazi2 = "fenerbahçe";

            if (sira.Contains("galatasaray"))
                Console.WriteLine("Sıramızda " + yazi1 + " var.");
            else
                Console.WriteLine("Sıramızda " + yazi1 + " yok.");

            if (sira.Contains("fenerbahçe"))
                Console.WriteLine("Sıramızda " + yazi2 + " var.");
            else
                Console.WriteLine("Sıramızda " + yazi2 + " yok.");

            if (sira.Contains(1995))
                Console.WriteLine("Sıramızda " + sayi1 + " var.");
            else
                Console.WriteLine("Sıramızda " + sayi1 + " yok.");

            //sira isimli nesmemizden bir eleman alalım: 

            object eleman = sira.Dequeue();
            Console.WriteLine("Sıramizin başından şunu aldık: " + eleman);

            //şimdi ise siranin en başındaki nesneyi öğrenelim.
            // Ama onu oradan çıkartmayacağız:

            eleman = sira.Peek();

            Console.WriteLine("Şuan sıramızın başındaki eleman " + eleman);

            // sıramızın içindeki elemanları silelim:

            sira.Clear();

            // Sıramızı temizledikten sonra kaç tane 
            //eleman bulunduğunu bulup yazalım.

            int elemanSayisi = sira.Count;

            Console.WriteLine("Sıramizda şu anda {0} tane eleman vardır.", elemanSayisi);
            Console.ReadLine();
        }
    }
}



